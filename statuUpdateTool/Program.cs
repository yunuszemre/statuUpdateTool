using Microsoft.EntityFrameworkCore;
using statuUpdateTool;
using statuUpdateTool.Models;
using statuUpdateTool.Tms_Models;
using System.Data.Common;
using System.Reflection.Metadata;
using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        string filePath = @"C:\\Users\\enoca-yunus\\Desktop\\UpdateToolRapor\\rapor.txt";

        using (StreamWriter file = File.CreateText(filePath))
        {
            
        
            Console.WriteLine("İşlem başladı");
            file.WriteLine("İşlem Başladı");
            CarrierRouteMapping updatedRoute = null;
            AccountCarrierBlacklist blackListUpdatedRoute = null;
            var context = new sehirContext();
            var tmsCont = new cl_tmsContext();
            var addList = new List<string>();
            var liste = context.HjHizmetBoLgeleris.ToList();
            var evetHayırListe = context.HbjDagıtımBolgeleriEvetHayirSayilis.ToList();
            var evetCount = 0;
            var hayirCount = 0;

            List<CityModel> cityList = new List<CityModel>();
            List<City> cities = tmsCont.Cities.ToList();
            List<Town> towns = tmsCont.Towns.Include(x => x.City).Include(x => x.Districts).ToList();
            List<District> districts = tmsCont.Districts.Include(x => x.City).Include(x => x.Town).ToList();
            List<Country> countries = tmsCont.Countries.ToList();

            int count = 1;
            foreach (var city in evetHayırListe)
            {

                var model = new CityModel
                {
                    City = city.Şehİr,
                    Town = city.İlçe,
                    EvetHayır = city.Evet > city.Hayir ? "hayır" : "evet",//evet ise veritabanına atılacak değer demek => City model aslında TownModel gibi düşünmek gerekiyor ilçe için dağıtım bölgesi içerisinde olan ve olmayan bölgelerin sayıları karşışaltırılıyor evet ise bu değer veritabanına gidecek hayırsa gitmeyecek
                    HayirSayisiSifirMi = city.Hayir == 0 ? true : false //=> //Hayır sayısı sıfırsa tüm değerler atılacak
                };
                cityList.Add(model);
            }
            List<CityModel> kullanilacakListe = new List<CityModel>();

            for (int i = 0; i < liste.Count; i++)
            {
                HjHizmetBoLgeleri bolge = liste[i];
                CityModel evetHayirCityModel = cityList.Find(x => x.City == bolge.Şehir && x.Town == bolge.İlçe);
                if (evetHayirCityModel.HayirSayisiSifirMi)
                {
                    var model = new CityModel()
                    {
                        City = bolge.Şehir,
                        Town = bolge.İlçe,
                        Mahalle = bolge.Mahalle,
                        EvetHayır = bolge.DağıtımAlanıİçerisindeMi,
                        HayirSayisiSifirMi = evetHayirCityModel.HayirSayisiSifirMi
                    };

                    kullanilacakListe.Add(model);


                }
                if (evetHayirCityModel.EvetHayır.ToLower() == bolge.DağıtımAlanıİçerisindeMi.ToLower())
                {
                    var model = new CityModel()
                    {
                        City = bolge.Şehir,
                        Town = bolge.İlçe,
                        Mahalle = bolge.Mahalle,
                        EvetHayır = bolge.DağıtımAlanıİçerisindeMi,
                        HayirSayisiSifirMi = evetHayirCityModel.HayirSayisiSifirMi
                    };

                    kullanilacakListe.Add(model);


                }


            }

            var etkilenenKayitSayisi = 1;
            //foreach (var item in kullanilacakListe)
            //{
            //    Console.WriteLine(item);
            //}
            var ilSay = cityList.GroupBy(x => x.City).Count();

            var ilceSay = cityList.GroupBy(x => x.Town).Count();
            int bulunamayanSAy = 0;
            using var transaction = tmsCont.Database.BeginTransaction();
            Console.WriteLine($"Trasaction Başlangıç Saati: {DateTime.Now}");
            file.WriteLine($"Trasaction Başlangıç Saati: {DateTime.Now}");
            var routes = tmsCont.CarrierRouteMappings.Include(x => x.Carrier).Include(x => x.City).Include(x => x.Town).Include(x => x.District).ToList();//.Where(x => x.Carrier.Code == "HBJ").ToList();
            var blackLists = tmsCont.AccountCarrierBlacklists.Include(x => x.Carrier).Include(x => x.City).Include(x => x.Town).Include(x => x.District).ToList();//Where(x => x.Carrier.Code == "HBJ").ToList();
            var updatedRoutes = new List<CarrierRouteMapping>();

            var startTime = DateTime.Now;

            Console.WriteLine($"\n\n\n{kullanilacakListe.Count}\n\n\n");
            try
            {

                foreach (var item in kullanilacakListe)
                {

                    bool isDbContains = towns.FindAll(x => x.City.Code == item.City && x.Code == item.Town).Count > 0 ? true : false;
                    if (!isDbContains)
                    {
                        file.WriteLine($"İlçe bulunamadı:{item.City} {item.Town}");
                        Console.WriteLine($"İlçe bulunamadı:{item.City} {item.Town}");
                        continue;
                    }

                    bool isDbContainsDistrict = districts.FindAll(x => x.City.Code == item.City && x.Town.Code == item.Town && x.Code == item.Mahalle).Count > 0 ? true : false;

                    if (!isDbContainsDistrict)
                    {
                        count++;
                        Console.WriteLine($"Mahalle bulunamadı:{item.City} {item.Town} {item.Mahalle}");
                        file.WriteLine($"Mahalle bulunamadı:{item.City} {item.Town} {item.Mahalle}");
                        //continue;
                        District dist = new District()
                        {
                            CityId = cities.FirstOrDefault(x => x.Code == item.City).CityId,
                            TownId = towns.FirstOrDefault(x => x.Code == item.Town).TownId,
                            Code = item.Mahalle,
                            Description = item.Mahalle,
                            CreatedDate = DateTime.Now,
                            RecordStatusId = 1,
                            IfTransferredToSecondary = false,
                        };
                        tmsCont.Districts.Add(dist);
                        tmsCont.SaveChanges();
                        Console.WriteLine($"Yeni Mahalle Eklendi: {item.City}-{item.Town}-{item.Mahalle}");
                        file.WriteLine($"Yeni Mahalle Eklendi: {item.City}-{item.Town}-{item.Mahalle}");
                    }
                    var countryId = 1;//countries.FirstOrDefault(x => x.Code == "TR").CountryId;
                    var cityId = cities.FirstOrDefault(x => x.Code == item.City).CityId;
                    var townId = towns.Find(x => x.Code == item.Town && x.CityId == cityId).TownId;
                    var districtId = tmsCont.Districts.FirstOrDefault(x => x.Code == item.Mahalle && x.TownId == townId).DistrictId;

                    Console.WriteLine($"İşlem Yapılan Şehir ID: {tmsCont.Cities.FirstOrDefault(x => x.Code == item.City).CityId}");
                    file.WriteLine($"İşlem Yapılan Şehir ID: {tmsCont.Cities.FirstOrDefault(x => x.Code == item.City).CityId}");
                    if (item.EvetHayır.ToLower() == "evet")
                    {
                        updatedRoute = routes.Find(r => r.Carrier.Code == "HBJ" && r.City.Code == item.City && r.Town.Code == item.Town && r.District.Code == item.Mahalle);
                        if (updatedRoute == null)
                        {
                            CarrierRouteMapping newRoute = new CarrierRouteMapping()
                            {

                                CarrierId = 2,//tmsCont.Carriers.FirstOrDefault(x => x.Code == "HBJ").CarrierId,
                                CountryId = countryId,//countries.FirstOrDefault(x => x.Code == "TR").CountryId,
                                CityId = cityId,//cities.FirstOrDefault(x => x.Code == item.City).CityId,
                                TownId = townId,//tmsCont.Towns.FirstOrDefault(x => x.Code == item.Town && x.CityId == item.City).TownId,
                                DistrictId = districtId,//tmsCont.Districts.FirstOrDefault(x => x.Code == item.Mahalle && x.Town.Code == item.Town).DistrictId,
                                CreatedDate = DateTime.Now,
                                CreateUserIdentityId = 2,
                                RecordStatusId = 1,//item.EvetHayır == "evet" ? 1 : 2,
                                RoutingLevel = 4,
                                CarrierRouteMappingMobileBranches = new List<CarrierRouteMappingMobileBranch>(),



                            };

                            tmsCont.CarrierRouteMappings.Add(newRoute);
                            //Console.WriteLine($"Eklenen kayıt: Taşıyıcı: {newRoute.Carrier.Code} Şehir: {newRoute.City.Code} İlçe: {newRoute.Town.Code} Mahalle: {newRoute.District.Code} Id: {newRoute.CarrierRouteMappingId}\n");
                            Console.WriteLine($"Ekleme: İşlem başarıyla tamamlandı, Etkilenen kayıt sayısı: {etkilenenKayitSayisi}\n");
                            file.WriteLine($"Ekleme: İşlem başarıyla tamamlandı, Etkilenen kayıt sayısı: {etkilenenKayitSayisi}");
                            //Console.WriteLine($"Kayıt bulunamadı deneme sayısı: {bulunamayanSAy}");
                        }
                        else
                        {
                            Console.WriteLine($"İşlem Yapılan Şehir ID: {updatedRoute.CityId}");
                            file.WriteLine("Update İşlemi--Normal");
                            file.WriteLine($"İşlem Yapılan Şehir ID: {updatedRoute.CityId}");
                            updatedRoute.CarrierId = 2;//tmsCont.Carriers.FirstOrDefault(x => x.Code == "HBJ").CarrierId;
                            updatedRoute.CountryId = tmsCont.Countries.FirstOrDefault(x => x.Code == "TR").CountryId;
                            updatedRoute.CityId = tmsCont.Cities.FirstOrDefault(x => x.Code == item.City).CityId;
                            updatedRoute.TownId = tmsCont.Towns.FirstOrDefault(x => x.Code == item.Town).TownId;
                            updatedRoute.DistrictId = tmsCont.Districts.FirstOrDefault(x => x.Code == item.Mahalle).DistrictId;
                            //updatedRoute.RecordStatusId = item.EvetHayır == "evet" ? 1 : 2;
                            updatedRoute.ChangedDate = DateTime.Now;
                            updatedRoute.ChangeUserIdentityId = 2;

                            tmsCont.CarrierRouteMappings.Update(updatedRoute);
                            Console.WriteLine($"İşlem başarıyla tamamlandı, Etkilenen kayıt sayısı: {etkilenenKayitSayisi}");

                        }
                    }
                    else
                    {
                        blackListUpdatedRoute = blackLists.Find(r => r.Carrier.Code == "HBJ" && r.City.Code == item.City && r.Town.Code == item.Town && r.District.Code == item.Mahalle);
                        if (blackListUpdatedRoute == null)
                        {
                            AccountCarrierBlacklist newBlackListRoute = new AccountCarrierBlacklist()
                            {
                                AccountId = 5,
                                LocationId = 52,
                                CarrierId = 2,
                                CountryId = countryId,//countries.FirstOrDefault(x => x.Code == "TR").CountryId,
                                CityId = cityId,//cities.FirstOrDefault(x => x.Code == item.City).CityId,
                                TownId = townId,//tmsCont.Towns.FirstOrDefault(x => x.Code == item.Town && x.CityId == item.City).TownId,
                                DistrictId = districtId,//tmsCont.Districts.FirstOrDefault(x => x.Code == item.Mahalle && x.Town.Code == item.Town).DistrictId,
                                CreatedDate = DateTime.Now,
                                CreateUserIdentityId = 2,
                                RecordStatusId = 1,//item.EvetHayır == "evet" ? 1 : 2,                               
                            };
                            tmsCont.AccountCarrierBlacklists.Add(newBlackListRoute);

                            Console.WriteLine($"BlackListEkleme: İşlem başarıyla tamamlandı, Etkilenen kayıt sayısı: {etkilenenKayitSayisi}\n");

                        }
                        else
                        {
                            Console.WriteLine("BlackListUpdate");
                            Console.WriteLine($"İşlem Yapılan Şehir ID: {blackListUpdatedRoute.CityId}");

                            blackListUpdatedRoute.CarrierId = 2;//tmsCont.Carriers.FirstOrDefault(x => x.Code == "HBJ").CarrierId;
                            blackListUpdatedRoute.CountryId = countryId;//tmsCont.Countries.FirstOrDefault(x => x.Code == "TR").CountryId;
                            blackListUpdatedRoute.CityId = cityId;//tmsCont.Cities.FirstOrDefault(x => x.Code == item.City).CityId;
                            blackListUpdatedRoute.TownId = townId;//tmsCont.Towns.FirstOrDefault(x => x.Code == item.Town).TownId;
                            blackListUpdatedRoute.DistrictId = districtId;//tmsCont.Districts.FirstOrDefault(x => x.Code == item.Mahalle).DistrictId;
                            blackListUpdatedRoute.ChangedDate = DateTime.Now;
                            blackListUpdatedRoute.ChangeUserIdentityId = 2;
                            


                            tmsCont.AccountCarrierBlacklists.Update(blackListUpdatedRoute);
                            Console.WriteLine($"Blacklist => İşlem başarıyla tamamlandı, Etkilenen kayıt sayısı: {etkilenenKayitSayisi}");
                            file.WriteLine("Update İşlemi--BlackList");
                            file.WriteLine($"Blacklist => İşlem başarıyla tamamlandı, Etkilenen kayıt sayısı: {etkilenenKayitSayisi}");
                            file.WriteLine($"İşlem Yapılan Şehir ID: {blackListUpdatedRoute.CityId}");
                        }
                    }

                    etkilenenKayitSayisi += tmsCont.SaveChanges();

                    // Commit transaction if all commands succeed, transaction will auto-rollback
                    // when disposed if either commands fails

                    //transaction.Dispose();
                }


            }
            catch (Exception ex)
            {
                // TODO: Handle failure
                Console.WriteLine(ex.Message);
            }
            finally
            {
                
                if (etkilenenKayitSayisi > 0)
                {
                    var endTime = DateTime.Now;
                    Console.WriteLine($"İşlem başarıyla tamamlandı, Etkilenen kayıt sayısı: {etkilenenKayitSayisi}");
                    Console.WriteLine($"TamamlanmaSaati: {endTime} Geçen Süre: {(endTime - startTime).TotalMinutes} dakika");
                    file.WriteLine($"İşlem başarıyla tamamlandı, Etkilenen kayıt sayısı: {etkilenenKayitSayisi}");
                    file.WriteLine($"TamamlanmaSaati: {endTime} Geçen Süre: {(endTime - startTime).TotalMinutes} dakika");
                    transaction.Commit();
                    transaction.Dispose();
                    Console.ReadLine();
                }
            }
        }
    }

}