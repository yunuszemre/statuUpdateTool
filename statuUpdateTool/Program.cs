using Microsoft.EntityFrameworkCore;
using statuUpdateTool;
using statuUpdateTool.Models;
using statuUpdateTool.Tms_Models;
using System.Data.Common;
using System.Reflection.Metadata;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("İşlem başladı");
        CarrierRouteMapping updatedRoute = null;
        var context = new sehirContext();
        var tmsCont = new cl_tmsContext();


        //var locs = tmsCont.CarrierRouteMappings.Include(x => x.City).Include(x => x.District).Include(x => x.Carrier).Include(x => x.Carrier).Include(x => x.Country).Where(x => x.Carrier.Code == "HBJ" && x.City.Code == "İstanbul").ToList().Distinct();
        ////locs.Select(x=>x.d)
        //var filtered = locs.Select(x => new
        //{
        //    CityId = x.CityId,
        //    City = x.City,
        //    CoutryId = x.CountryId,
        //    Country = x.Country,
        //    CarrierId = x.CarrierId,
        //    Carrier = x.Carrier,
        //    DistrictId = x.DistrictId,
        //    Distrcit = x.District

        //});
        //foreach (var item in filtered)
        //{
        //    Console.WriteLine(@$"{item.Country.Code,-20} {item.City.Code,-20} {item.Distrcit.Code,-20} {item.Carrier.Code,-20}");
        //}
        //var cities = tmsCont.Cities.ToList();
        //var val = new CarrierValueMapping();
        //val.CityId = cities.Find(c => c.Code == "İstanbul").CityId;
        ////val.CountryId = tmsCont.Countries.Find(c => c.Code == "TR").CountryId;



        var addList = new List<string>();
        var liste = context.HjHizmetBoLgeleris.ToList();
        var evetHayırListe = context.HbjDagıtımBolgeleriEvetHayirSayilis.ToList();
        var evetCount = 0;
        var hayirCount = 0;
        //Dictionary<string, string> map = new Dictionary<string, string>();

        List<CityModel> cityList = new List<CityModel>();
        string? currentCity;
        string? currentTown;
        string? previousCity;
        string? previousTown;
        foreach (var city in evetHayırListe)
        {

            var model = new CityModel
            {
                City = city.Şehİr,
                Town = city.İlçe,
                EvetHayır = city.Evet > city.Hayir ? "hayır" : "evet",
                HayirSayisiSifirMi = city.Hayir == 0 ? true : false
            };
            cityList.Add(model);
        }
        List<CityModel> kullanilacakListe = new List<CityModel>();
        for (int i = 0; i < liste.Count; i++)
        {
            HjHizmetBoLgeleri bolge = liste[i];
            CityModel evetHayir = cityList.Find(x => x.City == bolge.Şehir && x.Town == bolge.İlçe);
            if (evetHayir.HayirSayisiSifirMi)
            {
                var model = new CityModel()
                {
                    City = bolge.Şehir,
                    Town = bolge.İlçe,
                    Mahalle = bolge.Mahalle,
                    EvetHayır = bolge.DağıtımAlanıİçerisindeMi,
                    HayirSayisiSifirMi = evetHayir.HayirSayisiSifirMi
                };
                if (model.EvetHayır.ToLower() == "evet")
                {
                    kullanilacakListe.Add(model);

                }
            }
            if (evetHayir.EvetHayır.ToLower() == "evet")
            {
                var model = new CityModel()
                {
                    City = bolge.Şehir,
                    Town = bolge.İlçe,
                    Mahalle = bolge.Mahalle,
                    EvetHayır = bolge.DağıtımAlanıİçerisindeMi,
                    HayirSayisiSifirMi = evetHayir.HayirSayisiSifirMi
                };
                if (model.EvetHayır.ToLower() == "evet")
                {
                    kullanilacakListe.Add(model);

                }
            }
            else if (evetHayir.EvetHayır.ToLower() == "hayır")
            {
                var model = new CityModel()
                {
                    City = bolge.Şehir,
                    Town = bolge.İlçe,
                    Mahalle = bolge.Mahalle,
                    EvetHayır = bolge.DağıtımAlanıİçerisindeMi,
                    HayirSayisiSifirMi = evetHayir.HayirSayisiSifirMi
                };
                if (model.EvetHayır.ToLower() == "hayır")
                {
                    kullanilacakListe.Add(model);

                }
            }

        }
        #region EskiVersiyon
        //for (int i = 0; i < evetHayırListe.Count; i++)
        //{

        //    currentCity = liste[i].Şehir;
        //    currentTown = liste[i].İlçe;

        //    if (i > 0)
        //    {
        //        previousCity = liste[i - 1].Şehir;
        //        previousTown = liste[i - 1].İlçe;
        //        if (currentTown != previousTown)
        //        {

        //            CityModel model = new CityModel()
        //            {
        //                City = previousCity,
        //                Town = previousTown,
        //                EvetHayır = evetCount > hayirCount ? "hayır" : "evet",
        //                HayirSayisiSifirMi = hayirCount == 0 ? true : false,
        //            };
        //            cityList.Add(model);

        //            evetCount = 0;
        //            hayirCount = 0;
        //        }
        //        else
        //        {
        //            if (liste[i].DağıtımAlanıİçerisindeMi.ToLower() == "evet")
        //            {
        //                evetCount++;
        //            }
        //            else
        //            {
        //                hayirCount++;
        //            }
        //        }
        //    }


        //} 
        #endregion
        var etkilenenKayitSayisi = 1;
        //foreach (var item in kullanilacakListe)
        //{
        //    Console.WriteLine(item);
        //}
        var ilSay = cityList.GroupBy(x => x.City).Count();

        var ilceSay = cityList.GroupBy(x => x.Town).Count();
        int bulunamayanSAy = 0;
        using var transaction = tmsCont.Database.BeginTransaction();
        Console.WriteLine($"Başlangıç Saati: {DateTime.Now}");
        Console.WriteLine(kullanilacakListe[18]);
        Console.WriteLine(kullanilacakListe[17]);
        Console.WriteLine(kullanilacakListe[416]);
        Console.WriteLine(kullanilacakListe[544]);
        Console.WriteLine(kullanilacakListe[548]);
        kullanilacakListe.RemoveAt(18);
        kullanilacakListe.RemoveAt(259);
        kullanilacakListe.RemoveAt(416);
        kullanilacakListe.RemoveAt(544);
        kullanilacakListe.RemoveAt(548);

        var startTime = DateTime.Now;
        try
        {
            
            foreach (var item in kullanilacakListe)
            {
               
                updatedRoute = tmsCont.CarrierRouteMappings.FirstOrDefault(r => r.Carrier.Code.ToUpper() == "HBJ" && r.City.Code.ToUpper() == item.City.ToUpper() && r.Town.Code.ToUpper() == item.Town.ToUpper() && r.District.Code.ToUpper() == item.Mahalle.ToUpper());

                if (updatedRoute == null)
                {
                    bulunamayanSAy++;
                    CarrierRouteMapping newRoute = new CarrierRouteMapping()
                    {
                        CarrierId = 2,//tmsCont.Carriers.FirstOrDefault(x => x.Code == "HBJ").CarrierId,
                        TownId = tmsCont.Towns.FirstOrDefault(x => x.Code.ToUpper() == item.Town.ToUpper()).TownId,
                        CityId = tmsCont.Cities.FirstOrDefault(x => x.Code.ToUpper() == item.City.ToUpper()).CityId,
                        CountryId = tmsCont.Countries.FirstOrDefault(x => x.Code.ToUpper() == "TR").CountryId,
                        DistrictId = tmsCont.Districts.FirstOrDefault(x => x.Code == item.Mahalle).DistrictId,
                        CreatedDate = DateTime.Now,
                        CreateUserIdentityId = 2,
                        RecordStatusId = item.EvetHayır.ToLower() == "evet" ? 1 : 2,
                        Carrier = tmsCont.Carriers.FirstOrDefault(x => x.CarrierId == 2),
                        City = tmsCont.Cities.FirstOrDefault(x => x.Code == item.City),
                        Town = tmsCont.Towns.FirstOrDefault(x => x.Code == item.Town),
                        District = tmsCont.Districts.FirstOrDefault(x => x.Code == item.Mahalle),
                        CarrierRouteMappingMobileBranches = new List<CarrierRouteMappingMobileBranch>(),
                        IsMobileBranch = null,
                        RoutingLevel = 4,

                    };
                    if (newRoute == null)
                    {
                        Console.WriteLine(item);
                    }
                    tmsCont.CarrierRouteMappings.Add(newRoute);
                    Console.WriteLine($"Eklenen kayıt: Taşıyıcı: {newRoute.Carrier.Code} Şehir: {newRoute.City.Code} İlçe: {newRoute.Town.Code} Mahalle: {newRoute.District.Code} Id: {newRoute.CarrierRouteMappingId}\n");
                    Console.WriteLine($"İşlem başarıyla tamamlandı, Etkilenen kayıt sayısı: {etkilenenKayitSayisi}\n");
                    //Console.WriteLine($"Kayıt bulunamadı deneme sayısı: {bulunamayanSAy}");
                }
                else
                {
                    updatedRoute.CarrierId = 2;//tmsCont.Carriers.FirstOrDefault(x => x.Code == "HBJ").CarrierId;
                    updatedRoute.CountryId = tmsCont.Countries.FirstOrDefault(x => x.Code.ToUpper() == "TR").CountryId;
                    updatedRoute.CityId = tmsCont.Cities.FirstOrDefault(x => x.Code.ToUpper() == item.City.ToUpper()).CityId;
                    updatedRoute.TownId = tmsCont.Towns.FirstOrDefault(x => x.Code.ToUpper() == item.Town.ToUpper()).TownId;
                    updatedRoute.DistrictId = tmsCont.Districts.FirstOrDefault(x => x.Code.ToUpper() == item.Mahalle.ToUpper()).DistrictId;
                    updatedRoute.RecordStatusId = item.EvetHayır.ToLower() == "evet" ? 1 : 2;
                    updatedRoute.ChangedDate = DateTime.Now;
                    updatedRoute.ChangeUserIdentityId = 2;


                    tmsCont.CarrierRouteMappings.Update(updatedRoute);
                    Console.WriteLine($"İşlem başarıyla tamamlandı, Etkilenen kayıt sayısı: {etkilenenKayitSayisi}");

                }
                etkilenenKayitSayisi += tmsCont.SaveChanges();


                // Commit transaction if all commands succeed, transaction will auto-rollback
                // when disposed if either commands fails
            }

            transaction.Commit();
            transaction.Dispose();
        }
        catch (Exception ex)
        {
            // TODO: Handle failure
            throw new Exception(ex.Message);
        }
        finally
        {
            
            if (etkilenenKayitSayisi > 0)
            {
                var endTime = DateTime.Now;
                Console.WriteLine($"İşlem başarıyla tamamlandı, Etkilenen kayıt sayısı: {etkilenenKayitSayisi}");
                Console.WriteLine($"TamamlanmaSaati: {endTime} Geçen Süre: {(endTime-startTime).TotalMinutes} dakika");
                Console.ReadLine();
            }
        }
    }

}