using Microsoft.EntityFrameworkCore;
using statuUpdateTool;
using statuUpdateTool.Models;
using statuUpdateTool.Tms_Models;
using System.Text.Json;

internal class Program
{
    private static async Task Main(string[] args)
    {
        string filePath = @"C:\\Users\\enoca-yunus\\Desktop\\UpdateToolRapor\\rapor.txt";
        string? zipcode;

        using (StreamWriter file = File.CreateText(filePath))
        {
            int bulunamayanIlceSay = 0;

            #region PostaKodlarıİçinDataÇekenKısım
            //using HttpClient client = new HttpClient();
            //client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add(
            //    new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            //client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");
            //var cont = new sehirContext();
            //int requestCount = 0;
            //List<Postakodu> potaKodlari = new List<Postakodu>();
            //for (int i = 1; i < 82; i++)
            //{
            //    await PostaKodlariniGetir(client, i, potaKodlari, cont);
            //    await Console.Out.WriteLineAsync(requestCount.ToString());
            //    requestCount++;
            //    if (requestCount == 19)
            //    {
            //        await Task.Delay(65000);
            //        requestCount = 0;
            //    }
            //} 
            #endregion

            Console.WriteLine($"İşlem başladı: {DateTime.Now}");
            file.WriteLine("İşlem Başladı");
            CarrierRouteMapping? updatedRoute = null;
            AccountCarrierBlacklist? blackListUpdatedRoute = null;
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
            Console.WriteLine(towns[0].City.Code);

            int count = 0;
            int index = 0;
            int index2 = 0;
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
            List<CityModel> kullanilacakListe = context.CityModel.Where(x => x.IsSuccess == false).ToList();

            #region KullanlacakListeDbKayıt

            //for (int i = 0; i < liste.Count; i++)
            //{
            //    HjHizmetBoLgeleri bolge = liste[i];
            //    CityModel evetHayirCityModel = cityList.Find(x => x.City == bolge.Şehir && x.Town == bolge.İlçe);
            //    if (evetHayirCityModel.HayirSayisiSifirMi)
            //    {
            //        var model = new CityModel()
            //        {
            //            Id = Guid.NewGuid(),
            //            City = bolge.Şehir,
            //            Town = bolge.İlçe,
            //            Mahalle = bolge.Mahalle,
            //            EvetHayır = bolge.DağıtımAlanıİçerisindeMi,
            //            HayirSayisiSifirMi = evetHayirCityModel.HayirSayisiSifirMi,
            //            IsSuccess = false
            //        };

            //        kullanilacakListe.Add(model);
            //        var res = context.CityModel.Add(model);
            //        if (res != null)
            //        {

            //            await Console.Out.WriteLineAsync("CityModelDbkayır");
            //            context.SaveChanges();
            //        }


            //    }
            //    if (evetHayirCityModel.EvetHayır.ToLower() == bolge.DağıtımAlanıİçerisindeMi.ToLower())
            //    {
            //        var model = new CityModel()
            //        {
            //            Id = Guid.NewGuid(),
            //            City = bolge.Şehir,
            //            Town = bolge.İlçe,
            //            Mahalle = bolge.Mahalle,
            //            EvetHayır = bolge.DağıtımAlanıİçerisindeMi,
            //            HayirSayisiSifirMi = evetHayirCityModel.HayirSayisiSifirMi,
            //            IsSuccess = false
            //        };

            //        kullanilacakListe.Add(model);
            //        var res = context.CityModel.Add(model);
            //        if (res != null)
            //        {

            //            await Console.Out.WriteLineAsync("CityModelDbkayır");
            //            context.SaveChanges();
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

            Console.WriteLine($"Trasaction Başlangıç Saati: {DateTime.Now}");
            file.WriteLine($"Trasaction Başlangıç Saati: {DateTime.Now}");
            var routes = tmsCont.CarrierRouteMappings.Include(x => x.Carrier).Include(x => x.City).Include(x => x.Town).Include(x => x.District).ToList();//.Where(x => x.Carrier.Code == "HBJ").ToList();
            var blackLists = tmsCont.AccountCarrierBlacklists.Include(x => x.Carrier).Include(x => x.City).Include(x => x.Town).Include(x => x.District).Where(x => x.AccountId == 5 && x.CarrierId == 2).ToList();//Where(x => x.Carrier.Code == "HBJ").ToList();
            var updatedRoutes = new List<CarrierRouteMapping>();

            #region Excel-1
            //ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            //using (var package = new ExcelPackage())
            //{
            //    // Yeni bir çalışma sayfası ekleyin
            //    var worksheet = package.Workbook.Worksheets.Add("sayfa1");

            //    // Başlık satırını ekleyin
            //    worksheet.Cells[1, 1].Value = "AcocuntId";
            //    worksheet.Cells[1, 2].Value = "Id";
            //    worksheet.Cells[1, 3].Value = "İl";
            //    worksheet.Cells[1, 4].Value = "İlçe";
            //    worksheet.Cells[1, 5].Value = "Mahalle";

            //    // Verileri doldurun
            //    for (int i = 0; i < blackLists.Count; i++)
            //    {

            //        worksheet.Cells[i + 2, 1].Value = blackLists[i].AccountId;
            //        worksheet.Cells[i + 2, 2].Value = blackLists[i].AccountCarrierBlacklistId;
            //        worksheet.Cells[i + 2, 3].Value = blackLists[i].City.Code;
            //        worksheet.Cells[i + 2, 4].Value = blackLists[i].Town.Code;
            //        worksheet.Cells[i + 2, 5].Value = blackLists[i].District.Code;
            //    }


            //    // Excel dosyasını kaydedin
            //    //Console.WriteLine("\n*************blacklist excell eklendi***************\n");
            //    FileInfo fileInfo = new FileInfo(@"C:\\Users\\enoca-yunus\\Desktop\\UpdateToolRapor\\blackListDecathLonHBJ.xlsx");
            //    index2++;
            //    //fileInfo.CopyTo(@"C:\\Users\\enoca-yunus\\Desktop\\UpdateToolRapor\\rapor.xlsx");
            //    package.SaveAs(fileInfo);
            //} 
            #endregion

            var startTime = DateTime.Now;
            var blackListAdd = new List<CarrierRouteMapping>();
            var normalAdd = new List<AccountCarrierBlacklist>();
            var normalListAdd = new List<CityModel>();
            Console.WriteLine($"\n\n\n{kullanilacakListe.Count}\n\n\n");

            var denemeListe = kullanilacakListe.Skip(1500).Take(500);


            foreach (var item in denemeListe)
            {
                using var transaction = tmsCont.Database.BeginTransaction();
                try
                {

                    bool isDbContains = towns.FirstOrDefault(x => x.City.Code == item.City.ToUpper() && x.Code == item.Town.ToUpper()) != null ? true : false;
                    //Console.WriteLine(item.City + " " + item.Town);

                    var cityId = cities.FirstOrDefault(x => x.Code == item.City.ToUpper()).CityId;
                    if (!isDbContains)
                    {
                        var buyukSehirler = context.BüyükŞehirlers.ToList();


                        //İlçe Ekleme Kodu Buraya eklenecek
                        var buyukIl = buyukSehirler.Find(x => x.İl == item.City.ToUpper());
                        if (buyukIl != null && item.Town.ToUpper() == "MERKEZ")
                        {
                            continue;
                        }
                        else
                        {
                            Town addedTown = new Town()
                            {
                                CityId = cityId,
                                Code = item.Town.ToUpper(),
                                Description = item.Town.ToUpper(),
                                CreatedDate = DateTime.Now,
                                CreateUserIdentityId = 2,
                                RecordStatusId = 1,
                                IfTransferredToSecondary = false
                            };
                            tmsCont.Towns.Add(addedTown);
                            Console.WriteLine($"İlçe Eklendi: {item.City} {item.Town}");
                            towns.Add(addedTown);
                            tmsCont.SaveChanges();
                        }


                    }
                    else
                    {
                        long? itemId = 0;

                        #region Excel
                        //bool findedDistrict = tmsCont.Districts.FirstOrDefault(x => x.Code == item.Mahalle.ToUpper() && x.Town.Code == item.Town.ToUpper() && x.City.Code == item.City.ToUpper()) != null ? true : false;
                        //if (findedDistrict == false)
                        //{
                        //    Console.WriteLine("Mahalle Bulunamadı pas geçildi");
                        //    continue;
                        //}

                        //if (item.EvetHayır == "HAYIR")
                        //{

                        //    updatedRoute = routes.FirstOrDefault(r => r.CarrierId == 2 && r.City.Code == item.City.ToUpper() && r.Town.Code == item.Town.ToUpper() && r.District.Code == item.Mahalle.ToUpper());
                        //    //updatedRoute = routes.FirstOrDefault(r => r.CarrierId == 2 && r.City.Code == item.City.ToUpper() && r.Town.Code == item.Town.ToUpper() && r.District.Code == item.Mahalle.ToUpper());
                        //    //if (updatedRoute == null)
                        //    //{
                        //    //    continue;
                        //    //}
                        //    //if (updatedRoute != null)
                        //    //{
                        //    //    //Console.WriteLine($"BlackList Excelle yazılan ilçe {item.City} {item.Town} {item.Mahalle}");
                        //    //    ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                        //    //    blackListAdd.Add(updatedRoute);
                        //    //    // Excel dosyasını oluşturmak için yeni bir paket oluşturun

                        //    //}
                        //}
                        //else
                        //{

                        //    Console.WriteLine($"Normal Excelle yazılan ilçe {item.City} {item.Town} {item.Mahalle}");
                        //    if (item.Town.ToUpper() == "PINARHİSAR")
                        //    {
                        //        continue;
                        //    }
                        //    if (item.Town.ToUpper() == "VİRANŞEHİR")
                        //    {
                        //        continue;
                        //    }
                        //    if (itemId != 0)
                        //    {
                        //        blackListUpdatedRoute = blackLists.FirstOrDefault(r => r.Carrier.Code == "HBJ" && r.DistrictId == itemId);
                        //    }
                        //    else
                        //    {

                        //        blackListUpdatedRoute = blackLists.FirstOrDefault(r => r.CarrierId == 2 && r.City.Code == item.City.ToUpper() && r.Town.Code == item.Town.ToUpper() && r.District.Code == item.Mahalle.ToUpper());
                        //    }

                        //    if (blackListUpdatedRoute != null)
                        //    {
                        //        normalAdd.Add(blackListUpdatedRoute);
                        //    }
                        //}

                        #endregion

                        #region BlackListtenNormaleGeçecekler
                        //ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                        //// Excel dosyasını oluşturmak için yeni bir paket oluşturun
                        //using (var package = new ExcelPackage())
                        //{
                        //    // Yeni bir çalışma sayfası ekleyin
                        //    var worksheet = package.Workbook.Worksheets.Add("sayfa1");

                        //    // Başlık satırını ekleyin
                        //    worksheet.Cells[1, 1].Value = "Id";
                        //    worksheet.Cells[1, 2].Value = "İl";
                        //    worksheet.Cells[1, 3].Value = "İlçe";
                        //    worksheet.Cells[1, 4].Value = "Mahalle";

                        //    // Verileri doldurun
                        //    for (int i = 0; i < normalAdd.Count; i++)
                        //    {

                        //        worksheet.Cells[i + 2, 1].Value = normalAdd[i].AccountCarrierBlacklistId;
                        //        worksheet.Cells[i + 2, 2].Value = normalAdd[i].City.Code;
                        //        worksheet.Cells[i + 2, 3].Value = normalAdd[i].Town.Code;
                        //        worksheet.Cells[i + 2, 4].Value = normalAdd[i].District.Code;
                        //    }


                        //    // Excel dosyasını kaydedin
                        //    Console.WriteLine("\n*************blacklist excell eklendi***************\n");
                        //    FileInfo fileInfo = new FileInfo(@"C:\\Users\\enoca-yunus\\Desktop\\UpdateToolRapor\\blacklisttenNormalegeçecekler.xlsx");
                        //    index2++;
                        //    //fileInfo.CopyTo(@"C:\\Users\\enoca-yunus\\Desktop\\UpdateToolRapor\\rapor.xlsx");
                        //    package.SaveAs(fileInfo);
                        //} 
                        #endregion

                        #region NormaldenBlackListeGeçecekler
                        //using (var package = new ExcelPackage())
                        //{
                        //    // Yeni bir çalışma sayfası ekleyin
                        //    var worksheet = package.Workbook.Worksheets.Add("sayfa1");

                        //    // Başlık satırını ekleyin
                        //    worksheet.Cells[1, 1].Value = "Id";
                        //    worksheet.Cells[1, 2].Value = "İl";
                        //    worksheet.Cells[1, 3].Value = "İlçe";
                        //    worksheet.Cells[1, 4].Value = "Mahalle";

                        //    // Verileri doldurun
                        //    for (int i = 0; i < blackListAdd.Count; i++)
                        //    {
                        //        worksheet.Cells[i + 2, 1].Value = blackListAdd[i].CarrierRouteMappingId;
                        //        worksheet.Cells[i + 2, 2].Value = blackListAdd[i].City.Code;
                        //        worksheet.Cells[i + 2, 3].Value = blackListAdd[i].Town.Code;
                        //        worksheet.Cells[i + 2, 4].Value = blackListAdd[i].District.Code;
                        //    }



                        //    // Excel dosyasını kaydedin
                        //    FileInfo fileInfo = new FileInfo(@"C:\\Users\\enoca-yunus\\Desktop\\UpdateToolRapor\\normaldenBlackListegeçekler.xlsx");
                        //    index++;
                        //    package.SaveAs(fileInfo);
                        //} 
                        #endregion

                        #region SayılarÇıkarılırkenAlınanHataİçinEklendi

                        //bool isDbContains = towns.FindAll(x => x.City.Code == item.City.ToUpper() && x.Code == item.Town.ToUpper()).Count > 0 ? true : false;
                        //Console.WriteLine(item.City + " " + item.Town);
                        //if (!isDbContains)
                        //{
                        //    //file.WriteLine($"İlçe bulunamadı:{item.City} {item.Town}");
                        //    //Console.WriteLine($"İlçe bulunamadı:{item.City} {item.Town}");
                        //    //bulunamayanIlceSay++;
                        //    continue;
                        //}
                        //else
                        //{
                        //    Console.WriteLine("*******************************************************************\n");
                        //    Console.WriteLine($"Bulunan ilçe: {item.Town} {item.City}\n");
                        //    Console.WriteLine("*******************************************************************");
                        //}
                        //Console.WriteLine($"Bulunamayan ilçe say: {bulunamayanIlceSay}");
                        //Console.WriteLine($"Bulunamayan ilçe say: {bulunamayanIlceSay}"); 
                        #endregion

                        var isDbContainsDistrict = districts.FirstOrDefault(x => x.City.Code == item.City.ToUpper() && x.Town.Code == item.Town.ToUpper() && x.Code == item.Mahalle.ToUpper());
                        var countryId = 1;//countries.FirstOrDefault(x => x.Code == "TR").CountryId;
                        var townId = tmsCont.Towns.FirstOrDefault(x => x.Code == item.Town.ToUpper() && x.CityId == cityId).TownId;
                        if (isDbContainsDistrict == null)
                        {
                            count++;
                            Console.WriteLine($"Mahalle bulunamadı:{item.City} {item.Town} {item.Mahalle}");
                            file.WriteLine($"Mahalle bulunamadı:{item.City} {item.Town} {item.Mahalle}");
                            List<string> list = context.PostaKoduIdBilgilis.Where(x => x.Il.ToUpper() == item.City.ToUpper() && x.Ilce.ToUpper() == item.Town.ToUpper()).Select(x => x.Mahalle).ToList();
                            var mah = FindMostSimilarString(item.Mahalle, list);
                            zipcode = context.PostaKoduIdBilgilis.FirstOrDefault(x => x.Il.ToUpper() == item.City.ToUpper() && x.Ilce.ToUpper() == item.Town.ToUpper() && x.Mahalle == mah).Pk; //context.PostaKoduIdBilgilis.FirstOrDefault(x => x.Il.ToUpper() == item.City.ToUpper() && x.Ilce.ToUpper() == item.Town.ToUpper() && x.Mahalle.ToUpper().Contains(item.Mahalle.ToUpper()));//
                            if (zipcode != null)
                            {
                                //continue;
                                District dist = new District()
                                {
                                    CityId = cityId,//cities.FirstOrDefault(x => x.Code == item.City).CityId,
                                    TownId = townId,//towns.FirstOrDefault(x => x.Code == item.Town).TownId,
                                    Code = item.Mahalle,
                                    ZipCode = zipcode,
                                    Description = item.Mahalle,
                                    CreatedDate = DateTime.Now,
                                    RecordStatusId = 1,
                                    CreateUserIdentityId = 2,
                                    IfTransferredToSecondary = false,
                                };                                
                                tmsCont.Districts.Add(dist);
                                tmsCont.SaveChanges();
                                
                                districts.Add(dist);
                            }
                            else
                            {
                                District dist = new District()
                                {
                                    CityId = cityId,//cities.FirstOrDefault(x => x.Code == item.City).CityId,
                                    TownId = townId,//towns.FirstOrDefault(x => x.Code == item.Town).TownId,
                                    Code = item.Mahalle,
                                    Description = item.Mahalle,
                                    CreatedDate = DateTime.Now,
                                    RecordStatusId = 1,
                                    CreateUserIdentityId = 2,
                                    IfTransferredToSecondary = false,
                                };
                                tmsCont.Districts.Add(dist);
                                tmsCont.SaveChanges();
                                districts.Add(dist);

                            }
                            Console.WriteLine($"Yeni Mahalle Eklendi: {item.City}-{item.Town}-{item.Mahalle}");
                            file.WriteLine($"Yeni Mahalle Eklendi: {item.City}-{item.Town}-{item.Mahalle}");
                        }
                        //Mahalle ekleme kodu buraya gelecek => ZipCode lar eksik onlar tamamlanmalı

                        var districtId = tmsCont.Districts.FirstOrDefault(x => x.Code == item.Mahalle.ToUpper() && x.TownId == townId && x.CityId == cityId).DistrictId;

                        Console.WriteLine($"İşlem Yapılan Şehir ID: {tmsCont.Cities.FirstOrDefault(x => x.Code.ToUpper() == item.City.ToUpper()).CityId}");
                        file.WriteLine($"İşlem Yapılan Şehir ID: {tmsCont.Cities.FirstOrDefault(x => x.Code.ToUpper() == item.City.ToUpper()).CityId}");
                        if (item.EvetHayır.ToLower() == "evet")
                        {
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
                                Console.WriteLine($"RouteMapping Ekleme: İşlem başarıyla tamamlandı, Etkilenen kayıt sayısı: {etkilenenKayitSayisi}\n");
                                file.WriteLine($"RouteMapping Ekleme: İşlem başarıyla tamamlandı, Etkilenen kayıt sayısı: {etkilenenKayitSayisi}");
                                //Console.WriteLine($"Kayıt bulunamadı deneme sayısı: {bulunamayanSAy}");
                            }
                            else
                            {
                                #region Burada Normal Listeden BlackListe Geçme Kontrolü Yapılacak

                                CarrierRouteMapping blackListTrasfer = routes.FirstOrDefault(x => x.City.Code == item.City.ToUpper() && x.Town.Code == item.Town.ToUpper() && x.District.Code == item.Mahalle.ToUpper());
                                if (blackListTrasfer != null)
                                {
                                    blackListTrasfer.RecordStatusId = 2;
                                    tmsCont.CarrierRouteMappings.Update(blackListTrasfer);

                                    //Normal rotadan blakliste geçirme
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
                                    blackLists.Add(newBlackListRoute);
                                    Console.WriteLine($"BlackListEkleme: İşlem başarıyla tamamlandı, Etkilenen kayıt sayısı: {etkilenenKayitSayisi}\n");
                                    file.WriteLine("***************************************************");
                                    file.WriteLine($"Normal rotadan blackliste geçirme {item.City} {item.Town} {item.Mahalle}");
                                    #endregion
                                }
                                else
                                {

                                    Console.WriteLine($"İşlem Yapılan Şehir ID: {updatedRoute.CityId}");
                                    file.WriteLine("Update İşlemi--Normal");
                                    file.WriteLine($"İşlem Yapılan Şehir ID: {updatedRoute.CityId}");
                                    updatedRoute.CarrierId = 2;//tmsCont.Carriers.FirstOrDefault(x => x.Code == "HBJ").CarrierId;
                                    updatedRoute.CountryId = tmsCont.Countries.FirstOrDefault(x => x.Code == "TR").CountryId;
                                    updatedRoute.CityId = tmsCont.Cities.FirstOrDefault(x => x.Code == item.City.ToUpper()).CityId;
                                    updatedRoute.TownId = tmsCont.Towns.FirstOrDefault(x => x.Code == item.Town.ToUpper()).TownId;
                                    updatedRoute.DistrictId = tmsCont.Districts.FirstOrDefault(x => x.Code == item.Mahalle.ToUpper()).DistrictId;
                                    updatedRoute.ChangedDate = DateTime.Now;
                                    updatedRoute.ChangeUserIdentityId = 2;

                                    tmsCont.CarrierRouteMappings.Update(updatedRoute);
                                    Console.WriteLine($"RouteMapping update başarıyla tamamlandı, Etkilenen kayıt sayısı: {etkilenenKayitSayisi}");

                                }
                            }
                        }
                        else
                        {
                            blackListUpdatedRoute = blackLists.Find(r => r.Carrier.Code == "HBJ" && r.City.Code == item.City.ToUpper() && r.Town.Code == item.Town.ToUpper() && r.District.Code == item.Mahalle.ToUpper());

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
                                AccountCarrierBlacklist blackListtenNormale = blackLists.Find(r => r.City.Code == item.City.ToUpper() && r.Town.Code == item.Town.ToUpper() && r.District.Code == item.Mahalle.ToUpper());
                                if (blackListtenNormale != null)
                                {
                                    blackListtenNormale.RecordStatusId = 2;
                                    tmsCont.AccountCarrierBlacklists.Update(blackListtenNormale);

                                    //Normal rotaya transfer
                                    CarrierRouteMapping trasnferedRoute = new CarrierRouteMapping()
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

                                    tmsCont.CarrierRouteMappings.Add(trasnferedRoute);
                                    routes.Add(trasnferedRoute);
                                    //Console.WriteLine($"Eklenen kayıt: Taşıyıcı: {newRoute.Carrier.Code} Şehir: {newRoute.City.Code} İlçe: {newRoute.Town.Code} Mahalle: {newRoute.District.Code} Id: {newRoute.CarrierRouteMappingId}\n");
                                    Console.WriteLine($"Transfer Blacklist-Normal: İşlem başarıyla tamamlandı, Etkilenen kayıt sayısı: {etkilenenKayitSayisi}\n");
                                    file.WriteLine($"Blacklistten normale transfer: İşlem başarıyla tamamlandı, Etkilenen kayıt sayısı: {etkilenenKayitSayisi}");
                                    //Console.WriteLine($"Kayıt bulunamadı deneme sayısı: {bulunamayanSAy}");



                                }

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
                                file.WriteLine("***********************Update İşlemi--BlackList***********************");
                                file.WriteLine($"Blacklist => İşlem başarıyla tamamlandı, Etkilenen kayıt sayısı: {etkilenenKayitSayisi}");
                                file.WriteLine($"Blacklist => İşlem Yapılan Şehir ID: {blackListUpdatedRoute.CityId}");
                            }
                        }
                        
                        item.IsSuccess = true;
                        context.Update(item);
                        context.SaveChanges();
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
                        //Console.ReadLine();
                    }
                }


            }
        }
        static async Task PostaKodlariniGetir(HttpClient client, int index, List<Postakodu> postaKodlari, sehirContext context)
        {

            var json = await client.GetStreamAsync($"https://api.ubilisim.com/postakodu/il/{index}");
            Root data = JsonSerializer.Deserialize<Root>(json);

            foreach (var item in data.postakodu)
            {
                //postaKodlari.Add(item);
                if (item.pk != null)
                {

                    var model = new PostaKoduIdBilgili()
                    {
                        //Id = Guid.NewGuid(),
                        Il = item.il.ToUpper(),
                        Ilce = item.ilce.ToUpper(),
                        Mahalle = item.mahalle.ToUpper(),
                        Pk = item.pk,
                        Plaka = item.plaka,
                        SemtBucakBelde = item.semt_bucak_belde
                    };
                    context.PostaKoduIdBilgilis.Add(model);
                    context.SaveChanges();
                }

            }
        }
        static double Jaro(string s1, string s2)
        {
            if (s1 == null || s2 == null)
                return 0;

            int s1Len = s1.Length, s2Len = s2.Length;

            if (s1Len == 0 || s2Len == 0)
                return 0;

            int matchDistance = Math.Max(s1Len, s2Len) / 2 - 1;
            bool[] s1Matches = new bool[s1Len];
            bool[] s2Matches = new bool[s2Len];

            int matches = 0;
            int transpositions = 0;

            for (int i = 0; i < s1Len; i++)
            {
                int start = Math.Max(0, i - matchDistance);
                int end = Math.Min(i + matchDistance + 1, s2Len);

                for (int j = start; j < end; j++)
                {
                    if (s2Matches[j]) continue;
                    if (s1[i] != s2[j]) continue;

                    s1Matches[i] = true;
                    s2Matches[j] = true;
                    matches++;
                    break;
                }
            }

            if (matches == 0) return 0;

            int k = 0;
            for (int i = 0; i < s1Len; i++)
            {
                if (!s1Matches[i]) continue;

                while (!s2Matches[k]) k++;

                if (s1[i] != s2[k]) transpositions++;
                k++;
            }

            return ((double)matches / s1Len + (double)matches / s2Len + (double)(matches - transpositions / 2.0) / matches) / 3.0;
        }

        static double JaroWinkler(string s1, string s2, double p = 0.1)
        {
            double jaro = Jaro(s1, s2);
            int prefix = 0;
            while (prefix < s1.Length && prefix < s2.Length && s1[prefix] == s2[prefix])
            {
                prefix++;
            }
            return jaro + prefix * p * (1 - jaro);
        }

        static string FindMostSimilarString(string s1, List<string> stringArray)
        {
            if (stringArray == null || stringArray.Count == 0)
                return null;

            string mostSimilarString = stringArray[0];
            double highestSimilarity = JaroWinkler(s1, mostSimilarString);

            for (int i = 1; i < stringArray.Count; i++)
            {
                double similarity = JaroWinkler(s1, stringArray[i]);
                if (similarity > highestSimilarity)
                {
                    mostSimilarString = stringArray[i];
                    highestSimilarity = similarity;
                }
            }

            return mostSimilarString;
        }
    }
}//District ıd 152 kara listede ama artık olmaması lazım ne yapacaz ? => blacklistteki status ü 2 yapmak çözüm olabilir görüşülmeli Burak beyle
public class Postakodu
{
    public int plaka { get; set; }
    public string il { get; set; }
    public string ilce { get; set; }
    public string semt_bucak_belde { get; set; }
    public string mahalle { get; set; }
    public string pk { get; set; }
}

public class Root
{
    public bool success { get; set; }
    public string status { get; set; }
    public string dataupdatedate { get; set; }
    public string description { get; set; }
    public string pagecreatedate { get; set; }
    public List<Postakodu> postakodu { get; set; }
}