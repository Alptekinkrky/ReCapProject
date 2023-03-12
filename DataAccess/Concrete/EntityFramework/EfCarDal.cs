using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal
    {
        public List<Car> GetCarDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.brand_id equals b.brand_id
                             join co in context.Colors
                             on c.color_id equals co.color_id
                             select new Car
                             {
                                 brandId= brand_id,
                                 
                             }
                             
                             
                return result.ToList();

            }

        }
    }
}
