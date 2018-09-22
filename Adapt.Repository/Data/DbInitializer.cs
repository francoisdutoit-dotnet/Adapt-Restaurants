using Adapt.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapt.Repository.Data
{
    public class DbInitializer
    {
        public static void Initialize(RestaurantsDbContext context)
        {
            if (context.Restaurants.Any())
            {
                return;
            }

            var restaurants = new[]
            {
                new Restaurant {
                  Name ="McDonalds",
                  LogoName="mcdonalds_logo.png",
                  Branches =new Branch[]
                  {
                      new Branch {
                          Name ="La Lucia",
                          StreetName="My Street",
                          StreetNumber="12",
                          PostalCode="4159",
                          Suburb="La Lucia",
                          RestaurantTime = new List<RestaurantTime>()
                          {
                              new RestaurantTime(){Day = DayOfWeek.Monday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Tuesday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Wednesday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Thursday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Friday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Saturday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Sunday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)}
                          }
                      },
                      new Branch {
                          Name ="The Ridge",
                          StreetName="My Street",
                          StreetNumber="12",
                          PostalCode="4051",
                          Suburb="The Ridge",
                          RestaurantTime = new List<RestaurantTime>()
                          {
                              new RestaurantTime(){Day = DayOfWeek.Monday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Tuesday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Wednesday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Thursday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Friday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Saturday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Sunday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)}
                          }
                      },
                      new Branch {
                          Name ="Gateway",
                          StreetName="My Street",
                          StreetNumber="12",
                          PostalCode="4051",
                          Suburb="Gateway",
                          RestaurantTime = new List<RestaurantTime>()
                          {
                              new RestaurantTime(){Day = DayOfWeek.Monday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Tuesday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Wednesday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Thursday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Friday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Saturday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Sunday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)}
                          }
                      },
                      new Branch {
                          Name ="Kloof",
                          StreetName="My Street",
                          StreetNumber="12",
                          PostalCode="3610",
                          Suburb="Kloof",
                          RestaurantTime = new List<RestaurantTime>()
                          {
                              new RestaurantTime(){Day = DayOfWeek.Monday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Tuesday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Wednesday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Thursday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Friday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Saturday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Sunday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)}
                          }
                      },
                  }
                },
                  new Restaurant {
                  Name ="Nandos",
                  LogoName="nandos_logo.png",
                  Branches =new Branch[]
                  {
                      new Branch {
                          Name ="La Lucia",
                          StreetName="My Street",
                          StreetNumber="12",
                          PostalCode="4159",
                          Suburb="La Lucia",
                          RestaurantTime = new List<RestaurantTime>()
                          {
                              new RestaurantTime(){Day = DayOfWeek.Monday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Tuesday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Wednesday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Thursday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Friday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Saturday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Sunday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)}
                          }
                      },
                      new Branch {
                          Name ="The Ridge",
                          StreetName="My Street",
                          StreetNumber="12",
                          PostalCode="4051",
                          Suburb="The Ridge",
                          RestaurantTime = new List<RestaurantTime>()
                          {
                              new RestaurantTime(){Day = DayOfWeek.Monday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Tuesday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Wednesday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Thursday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Friday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Saturday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Sunday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)}
                          }
                      },
                      new Branch {
                          Name ="Gateway",
                          StreetName="My Street",
                          StreetNumber="12",
                          PostalCode="4051",
                          Suburb="Gateway",
                          RestaurantTime = new List<RestaurantTime>()
                          {
                              new RestaurantTime(){Day = DayOfWeek.Monday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Tuesday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Wednesday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Thursday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Friday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Saturday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Sunday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)}
                          }
                      },
                      new Branch {
                          Name ="Hillcrest",
                          StreetName="My Street",
                          StreetNumber="12",
                          PostalCode="3610",
                          Suburb="Hillcrest",
                          RestaurantTime = new List<RestaurantTime>()
                          {
                              new RestaurantTime(){Day = DayOfWeek.Monday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Tuesday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Wednesday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Thursday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Friday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Saturday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Sunday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)}
                          }
                      },
                  }
                },
                  new Restaurant {
                  Name ="Spur",
                  LogoName="spur_logo.png",
                  Branches =new Branch[]
                  {
                      new Branch {
                          Name ="La Lucia",
                          StreetName="My Street",
                          StreetNumber="12",
                          PostalCode="4159",
                          Suburb="La Lucia",
                          RestaurantTime = new List<RestaurantTime>()
                          {
                              new RestaurantTime(){Day = DayOfWeek.Monday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Tuesday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Wednesday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Thursday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Friday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Saturday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Sunday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)}
                          }
                      },
                      new Branch {
                          Name ="The Ridge",
                          StreetName="My Street",
                          StreetNumber="12",
                          PostalCode="4051",
                          Suburb="The Ridge",
                          RestaurantTime = new List<RestaurantTime>()
                          {
                              new RestaurantTime(){Day = DayOfWeek.Monday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Tuesday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Wednesday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Thursday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Friday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Saturday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Sunday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)}
                          }
                      },
                      new Branch {
                          Name ="Gateway",
                          StreetName="My Street",
                          StreetNumber="12",
                          PostalCode="4051",
                          Suburb="Gateway",
                          RestaurantTime = new List<RestaurantTime>()
                          {
                              new RestaurantTime(){Day = DayOfWeek.Monday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Tuesday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Wednesday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Thursday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Friday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Saturday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Sunday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)}
                          }
                      },
                      new Branch {
                          Name ="Hillcrest",
                          StreetName="My Street",
                          StreetNumber="12",
                          PostalCode="3610",
                          Suburb="Hillcrest",
                          RestaurantTime = new List<RestaurantTime>()
                          {
                              new RestaurantTime(){Day = DayOfWeek.Monday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Tuesday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Wednesday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Thursday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Friday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Saturday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Sunday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)}
                          }
                      },
                  }
                },
                  new Restaurant {
                  Name ="Steers",
                  LogoName="steers_logo.png",
                  Branches =new Branch[]
                  {
                      new Branch {
                          Name ="La Lucia",
                          StreetName="My Street",
                          StreetNumber="12",
                          PostalCode="4159",
                          Suburb="La Lucia",
                          RestaurantTime = new List<RestaurantTime>()
                          {
                              new RestaurantTime(){Day = DayOfWeek.Monday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Tuesday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Wednesday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Thursday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Friday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Saturday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Sunday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)}
                          }
                      },
                      new Branch {
                          Name ="The Ridge",
                          StreetName="My Street",
                          StreetNumber="12",
                          PostalCode="4051",
                          Suburb="The Ridge",
                          RestaurantTime = new List<RestaurantTime>()
                          {
                              new RestaurantTime(){Day = DayOfWeek.Monday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Tuesday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Wednesday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Thursday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Friday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Saturday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Sunday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)}
                          }
                      },
                      new Branch {
                          Name ="Gateway",
                          StreetName="My Street",
                          StreetNumber="12",
                          PostalCode="4051",
                          Suburb="Gateway",
                          RestaurantTime = new List<RestaurantTime>()
                          {
                              new RestaurantTime(){Day = DayOfWeek.Monday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Tuesday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Wednesday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Thursday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Friday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Saturday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Sunday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)}
                          }
                      },
                      new Branch {
                          Name ="Hillcrest",
                          StreetName="My Street",
                          StreetNumber="12",
                          PostalCode="3610",
                          Suburb="Hillcrest",
                          RestaurantTime = new List<RestaurantTime>()
                          {
                              new RestaurantTime(){Day = DayOfWeek.Monday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Tuesday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Wednesday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Thursday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Friday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Saturday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Sunday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)}
                          }
                      },
                      new Branch {
                          Name ="Kloof",
                          StreetName="My Street",
                          StreetNumber="12",
                          PostalCode="3610",
                          Suburb="Kloof",
                          RestaurantTime = new List<RestaurantTime>()
                          {
                              new RestaurantTime(){Day = DayOfWeek.Monday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Tuesday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Wednesday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Thursday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Friday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(10,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Saturday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)},
                              new RestaurantTime(){Day = DayOfWeek.Sunday,OpenTime = new TimeSpan(5,30,0),CloseTime=new TimeSpan(23,0,0)}
                          }
                      },
                  }
                }

            };

            foreach (var restaurant in restaurants)
            {
                context.Restaurants.Add(restaurant);
            }
            context.SaveChanges();

        }
    }
}
