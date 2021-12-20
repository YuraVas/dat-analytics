﻿using System;
using System.Collections.Generic;

namespace Dat.Access.Loads.Request
{

    public class SearchRequestBuilder
    {
        private SearchRequestBuilder() { }

        public static SearchRequestBuilder NewBuilder()
        {
            return new SearchRequestBuilder();
        }

        public SearchRequest Build()
        {
            return new SearchRequest
            {
                criteria = new Criteria
                {
                    desiredSpecs = new DesiredSpecs()
                    {
                        equipmentClasses = new List<string> { "F" },
                        capacity = "FULL",
                        maxWeightInPounds = 48000
                    },
                    origin = new Origin()
                    {
                        point = new Point()
                        {
                            city = "Chicago",
                            state = "IL",
                            latitude = 41.881832,
                            longitude = -87.623177,
                            deadhead = new Deadhead()
                            {
                                miles = 150
                            }
                        }
                    },
                    destination = new Destination()
                    {
                        area = new Area()
                        {
                            zones = new List<string> { "Z1" }
                        }
                    },
                    maxAgeInMinutes = 360,
                    availability = new Availability()
                    {
                        earliest = DateTime.UtcNow.AddHours(-6).ToString("O"),
                        latest = DateTime.UtcNow.AddHours(1).ToString("O"),
                    }
                }
            };
        }

        public SearchRequest TestBuild(DateTime utcNow)
        {
            return new SearchRequest
            {
                criteria = new Criteria
                {
                    desiredSpecs = new DesiredSpecs()
                    {
                        equipmentClasses = new List<string> { "F" },
                        capacity = "FULL",
                        maxWeightInPounds = 48000
                    },
                    origin = new Origin()
                    {
                        point = new Point()
                        {
                            city = "Chicago",
                            state = "IL",
                            latitude = 41.881832,
                            longitude = -87.623177,
                            deadhead = new Deadhead()
                            {
                                miles = 150
                            }
                        }
                    },
                    destination = new Destination()
                    {
                        area = new Area()
                        {
                            zones = new List<string> { "Z1" }
                        }
                    },
                    maxAgeInMinutes = 5940,
                    availability = new Availability()
                    {
                        earliest = utcNow.AddHours(-1).ToString("O"),
                        latest = utcNow.AddHours(24).ToString("O"),
                    }
                }
            };
        }
    }
}
