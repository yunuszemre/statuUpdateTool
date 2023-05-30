using Microsoft.EntityFrameworkCore;
using statuUpdateTool.Models;
using statuUpdateTool.Tms_Models;
using System.Data.Common;
using System.Reflection.Metadata;

internal class Program
{
    private static void Main(string[] args)
    {

        var context = new sehirContext();
        var tmsCont = new cl_tmsContext();


        var locs = tmsCont.CarrierRouteMappings.Include(x => x.City).Include(x => x.District).Include(x => x.Carrier).Include(x => x.Carrier).Include(x => x.Country).Where(x => x.Carrier.Code == "HBJ" && x.City.Code == "İstanbul").ToList().Distinct();
        //locs.Select(x=>x.d)
        var filtered = locs.Select(x => new
        {
            CityId = x.CityId,
            City = x.City,
            CoutryId = x.CountryId,
            Country = x.Country,
            CarrierId = x.CarrierId,
            Carrier = x.Carrier,
            DistrictId = x.DistrictId,
            Distrcit = x.District

        });
        foreach (var item in filtered)
        {
            Console.WriteLine(@$"{item.Country.Code,-20} {item.City.Code,-20} {item.Distrcit.Code,-20} {item.Carrier.Code,-20}");
        }
        var cities = tmsCont.Cities.ToList();
        var val = new CarrierValueMapping();
        val.CityId = cities.Find(c => c.Code == "İstanbul").CityId;
        //val.CountryId = tmsCont.Countries.Find(c => c.Code == "TR").CountryId;
        using var transaction = tmsCont.Database.BeginTransaction();

        try
        {
            CarrierRouteMapping updatedRoute = tmsCont.CarrierRouteMappings.FirstOrDefault(r => r.Carrier.Code == "HBJ" && r.City.Code == "İstanbul" && r.Town.Code == "Merkez" && r.District.Code == "ŞeyhŞamil");

            if (updatedRoute == null)
            {
                CarrierRouteMapping newRoute = new CarrierRouteMapping()
                {
                    CarrierId = tmsCont.Carriers.FirstOrDefault(x => x.Code == "HBJ").CarrierId,
                    TownId = tmsCont.Towns.FirstOrDefault(x => x.Code == "İstanbul").TownId,


                };
                tmsCont.CarrierRouteMappings.Add(newRoute);
                
            }
            else
            {
                updatedRoute.CarrierId = tmsCont.Carriers.FirstOrDefault(x => x.Code == "HBJ").CarrierId;

                tmsCont.CarrierRouteMappings.Update(updatedRoute);
                
            }

            // Commit transaction if all commands succeed, transaction will auto-rollback
            // when disposed if either commands fails
            tmsCont.SaveChanges();
            transaction.Commit();
            
        }
        catch (Exception)
        {
            // TODO: Handle failure
            throw;
        }
        finally
        {
            transaction.Dispose();
        }
        

        Console.WriteLine("Hello, World!");
    }
}