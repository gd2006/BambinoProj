﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambinoProj.IFS
{
    public static class DBhelper
    {
        private static dbEntities db;

        public static List<prodExtraKeys> prodExtraKeysList;
        public static List<productExtraData> productExtraDataList;
        public static List<productTBL> productList;
        public static List<productTypeTBL> productTypeList;
        public static List<productView> productViewList;
        public static List<EmployesTBL> employesList;
        public static List<ClientsTBL> clientsList;
        public static void init()
        {
            db = new dbEntities();
            loadall();
        }
        #region load function
        public static void loadall()
        {
            loadprodExtraKeysList();
            loadproductExtraDataList();
            loadproductList();
            loadproductTypeList();
            loadPrductViewList();
            loadEmployesList();
            loadclientList();
        }


        public static void loadPrductViewList()
        {
            productViewList = (from s in db.productView select s).ToList();
        }

        public static void loadprodExtraKeysList()
        {
            prodExtraKeysList = (from s in db.prodExtraKeys orderby s.KeyName select s).ToList();
        }
        public static void loadproductExtraDataList()
        {
            productExtraDataList = (from s in db.productExtraData select s).ToList();
        }
        public static void loadproductList()
        {
            productList = (from s in db.productTBL orderby s.prodName select s).ToList();
        }
        public static void loadproductTypeList()
        {
            productTypeList = (from s in db.productTypeTBL orderby s.typeName select s).ToList();
        }
        public static void loadclientList()
        {
            clientsList = (from s in db.ClientsTBL select s).ToList();

        }

        public static void loadEmployesList()
        {
            employesList = (from s in db.EmployesTBL  select s).ToList();
            employesList = employesList.OrderBy(x => x.EmployedLastName).ThenBy(x => x.EmployedName).ToList();
        }
        #endregion




        #region add function
        public static prodExtraKeys addprodExtraKeys(prodExtraKeys productKey)
        {
            try
            {
                db.prodExtraKeys.Add(productKey);
                db.SaveChanges();
                loadprodExtraKeysList();
                return productKey;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static productExtraData addproductExtraData(productExtraData prodEData)
        {
            try
            {
                db.productExtraData.Add(prodEData);
                db.SaveChanges();
                loadproductExtraDataList();
                loadPrductViewList();   
                return prodEData;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static productTBL addproductList(productTBL product)
        {
            try
            {
                db.productTBL.Add(product);
                db.SaveChanges();
                loadproductList();
                return product;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static productTypeTBL addproductTypeList(productTypeTBL productType)
        {
            try
            {
                db.productTypeTBL.Add(productType);
                db.SaveChanges();
                loadproductTypeList();
                return productType;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static ClientsTBL addclients(ClientsTBL client)
        {
            try
            {
                db.ClientsTBL.Add(client);
                db.SaveChanges();
                loadclientList();
                return client;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

            public static EmployesTBL addEmployed(EmployesTBL employed)
        {
            try
            {
                db.EmployesTBL.Add(employed);
                db.SaveChanges();
                loadEmployesList();
                return employed;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion


        #region update function 
        public static bool updateExtraKey(prodExtraKeys prodEK)
        {
            try
            {
                prodExtraKeys toUpdate = (from s in db.prodExtraKeys where s.Id == prodEK.Id select s).FirstOrDefault();
                if (toUpdate == null)
                    return false;
                toUpdate.KeyName = prodEK.KeyName;
                toUpdate.KeyDescription = prodEK.KeyDescription;
                db.SaveChanges();
                loadprodExtraKeysList();
                return true;
            }
            catch (Exception ex) {
                return false;
            }
        }
        public static bool updateExtraDataList(productExtraData prodEData)
        {
            try
            {
                productExtraData toUpdate = (from s in db.productExtraData where s.Id == prodEData.Id select s).FirstOrDefault();
                if (toUpdate == null)
                    return false;
                toUpdate.value = prodEData.value;
                toUpdate.keyID = prodEData.keyID;
                toUpdate.productID = prodEData.productID;
                db.SaveChanges();
                loadproductExtraDataList();
                loadPrductViewList();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool updateproductList(productTBL product)
        {
            try
            {
                productTBL toUpdate = (from s in db.productTBL where s.Id == product.Id select s).FirstOrDefault();
                if (toUpdate == null)
                    return false;
                toUpdate.price = product.price;
                toUpdate.prodName = product.prodName;
                toUpdate.typeID = product.typeID;
                toUpdate.inStock = product.inStock;
                db.SaveChanges();
                loadproductList();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool updateproductTypeList(productTypeTBL prodType)
        {
            try
            {
                productTypeTBL toUpdate = (from s in db.productTypeTBL where s.Id == prodType.Id select s).FirstOrDefault();
                if (toUpdate == null)
                    return false;
                toUpdate.typeName = prodType.typeName;
                toUpdate.description = prodType.description;
                db.SaveChanges();
                loadproductTypeList();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool updateClient(ClientsTBL client)
        {
            try
            {
                ClientsTBL toUpdate = (from s in db.ClientsTBL where s.Id == client.Id select s).FirstOrDefault();
                if (toUpdate == null)
                    return false;
                toUpdate.clientName = client.clientName;
                toUpdate.clientLastName = client.clientLastName;
                toUpdate.clientPhone = client.clientPhone;
                toUpdate.paymentMethod = client.paymentMethod;
                toUpdate.clientInstitutionSymbol = client.clientInstitutionSymbol;
                toUpdate.Email = client.Email;
                db.SaveChanges();
                loadclientList();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool updateEmployesList(EmployesTBL employed)
        {
            try
            {
                EmployesTBL toUpdate = (from s in db.EmployesTBL where s.Id == employed.Id select s).FirstOrDefault();
                if (toUpdate == null)
                    return false;
                toUpdate.EmployedName = employed.EmployedName;
                toUpdate.EmployedLastName = employed.EmployedLastName;
                toUpdate.Email = employed.Email;
                toUpdate.BirthDate = employed.BirthDate;
                toUpdate.PhoneNumber = employed.PhoneNumber;
                toUpdate.NameOfTheBank = employed.NameOfTheBank;
                toUpdate.BankBranchNumber = employed.BankBranchNumber;
                toUpdate.BankAccountNumber = employed.BankAccountNumber;

                db.SaveChanges();
                loadEmployesList();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        #endregion
    }
}
