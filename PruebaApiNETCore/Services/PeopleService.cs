﻿using PruebaApiNETCore.Models;

namespace PruebaApiNETCore.Services
{
    public class PeopleService : IPeopleService
    {
        public bool Validate(People people)
        {
            if (string.IsNullOrEmpty(people.Name))
            {
                return false;
            }

            return true;
        }
    }
}
