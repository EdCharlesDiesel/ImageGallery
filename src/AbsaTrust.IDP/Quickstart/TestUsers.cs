// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityModel;
using IdentityServer4.Test;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text.Json;
using IdentityServer4;

namespace IdentityServerHost.Quickstart.UI
{
    public class TestUsers
    {
        public static List<TestUser> Users
        {
            get
            {
             
                
                return new List<TestUser>
                {
                    new TestUser
                    {
                        SubjectId = "406F3E11-E582-464B-A38F-20D64CA5304B",
                        Username = "Khotso",
                        Password = "password",
                        Claims =new  List<Claim>
                        {
                            new Claim(JwtClaimTypes.GivenName, "Khotso"),
                            new Claim(JwtClaimTypes.FamilyName, "Mokhethi")                        
                            }
                    },
                    new TestUser
                    {
                        SubjectId = "ECE03339-EA16-42BC-AA55-A28E55C50285",
                        Username = "John",
                        Password = "password",
                        Claims = new List<Claim>
                        {
                            
                            new Claim(JwtClaimTypes.GivenName, "John"),
                            new Claim(JwtClaimTypes.FamilyName, "Cory")
                            
                        }
                    }
                };
            }
        }
    }
}