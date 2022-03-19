﻿using ECommerce.DataAccess.Concrete.EntityFramework;
using ECommerce.DataAccess.Concrete.EntityFramework.UserManagement.Address;
using ECommerce.DataAccess.Migrations.Helpers;
using ECommerce.Entities.Concrete.UserManagement.Address;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce.DataAccess.Migrations
{
    public partial class SeedAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            using (var context = new ECommerceContext())
            {
                var countryList = LoadDataHelper.GetEntityListFromJsonFile<AddressCountry>(@"Migrations\Datas\countries.json");
                var stateList = LoadDataHelper.GetEntityListFromJsonFile<AddressState>(@"Migrations\Datas\states.json");
                var cityList = LoadDataHelper.GetEntityListFromJsonFile<AddressCity>(@"Migrations\Datas\cities.json");

                var countryDal = new EfAddressCountryDal();
                var stateDal = new EfAddressStateDal();
                var cityDal = new EfAddressCityDal();

                foreach (var addressCountry in countryList)
                {
                    addressCountry.Id = 0;
                    countryDal.Add(addressCountry);
                }

                foreach (var addressState in stateList)
                {
                    addressState.Id = 0;
                    stateDal.Add(addressState);
                }

                foreach (var addressCity in cityList)
                {
                    addressCity.Id = 0;
                    cityDal.Add(addressCity);
                }
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM AddressCities", true);
            migrationBuilder.Sql("DELETE FROM AddressStates", true);
            migrationBuilder.Sql("DELETE FROM AddressCountries", true);
        }
    }
}
