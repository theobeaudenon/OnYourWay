using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{
    class utilsDB
    {
        static Model1Container DB = new Model1Container();

        /*
         * Apelle base de donné concernant les employés
         */
        public static void AddEmployee(String nom, String prenom)
        {
            EmployeesSet newEmployee = new EmployeesSet();
            newEmployee.Nom = nom;
            newEmployee.Prenom = prenom;


            DB.EmployeesSet.Add(newEmployee);
            DB.SaveChanges();
        }
        public static EmployeesSet  GetEmployee(int id)
        {
            foreach (EmployeesSet emps in utilsDB.listEmployee())
            {
                if (emps.Id == id)
                {
                    return emps;
                }
            }
            return null;
        }
        public static void RemoveEmployee(int ID)
        {
            var serveurQuery = from employee in DB.EmployeesSet
                               where employee.Id == ID
                               select employee;
            EmployeesSet objdriver = serveurQuery.Single();

            DB.EmployeesSet.Remove(objdriver);
            DB.SaveChanges();
        }

        public static void UpdateEmployee(String nom, String prenom, int ID)
        {
            var serveurQuery = from employee in DB.EmployeesSet
                               where employee.Id == ID
                               select employee;
            EmployeesSet objdriver = serveurQuery.Single();

            objdriver.Prenom = prenom;
            objdriver.Nom = nom;
            DB.SaveChanges();
        }


        public static List<EmployeesSet> listEmployee()
        {
            return DB.EmployeesSet.ToList<EmployeesSet>();
           
        }

        /*
         * Apelle base de donné concernant les Produits
         */
        public static void AddProduct(String nom, int prix, int categorieID, Boolean empty)
        {
            ProductsSet newProduct = new ProductsSet();
            newProduct.Nom = nom;
            newProduct.Prix = prix;
            newProduct.CheckEmpty = empty;
            newProduct.CategoriesId = categorieID;

            DB.ProductsSet.Add(newProduct);
            DB.SaveChanges();
        }

        public static void RemoveProduct(int ID)
        {
            var serveurQuery = from product in DB.ProductsSet
                               where product.Id == ID
                               select product;
            ProductsSet objDishes = serveurQuery.Single();

            DB.ProductsSet.Remove(objDishes);
            DB.SaveChanges();
        }

        public static void UpdateProduct(String nom, int prix, int ID, Boolean empty, int categorieID)
        {
            var serveurQuery = from product in DB.ProductsSet
                               where product.Id == ID
                               select product;
            ProductsSet objdriver = serveurQuery.Single();

            objdriver.Prix = prix;
            objdriver.Nom = nom;
            objdriver.CheckEmpty = empty;
            objdriver.CategoriesId = categorieID;
            DB.SaveChanges();
        }

        public static List<ProductsSet> listProduct()
        {
            return DB.ProductsSet.ToList<ProductsSet>();

        }


        /*
         * Apelle base de donné concernant les Caisses
         */
        public static void AddCheckout(int x, int y, int id )
        {
            CheckoutSet newCheckout = new CheckoutSet();
            newCheckout.X = x;
            newCheckout.Y = y;  
            newCheckout.EmployeesId = id;
            DB.CheckoutSet.Add(newCheckout);
            DB.SaveChanges();
        }

        public static void RemoveCheckout(int ID)
        {
            var serveurQuery = from checkout in DB.CheckoutSet
                               where checkout.Id == ID
                               select checkout;
            CheckoutSet objDishes = serveurQuery.Single();

            DB.CheckoutSet.Remove(objDishes);
            DB.SaveChanges();
        }

        public static void UpdateCheckout(int x, int y, int employeeID, int ID)
        {
            var serveurQuery = from product in DB.CheckoutSet
                               where product.Id == ID
                               select product;
            CheckoutSet objdriver = serveurQuery.Single();

            objdriver.X = x;
            objdriver.Y = y;
            objdriver.EmployeesId = employeeID;
            DB.SaveChanges();
        }

        public static List<CheckoutSet> listCheckout()
        {
            return DB.CheckoutSet.ToList<CheckoutSet>();

        }

        /*
         * Apelle base de donné concernant les Catégories
         */
        public static void AddCategorie(String nom)
        {
            CategoriesSet newCategorie = new CategoriesSet();
            newCategorie.Nom = nom;



            DB.CategoriesSet.Add(newCategorie);
            DB.SaveChanges();
        }
        public static CategoriesSet GetCategorie(int id)
        {
            foreach (CategoriesSet emps in utilsDB.listCategorie())
            {
                if (emps.Id == id)
                {
                    return emps;
                }
            }
            return null;
        }
        public static void RemoveCategorie(int ID)
        {
            var serveurQuery = from categorie in DB.CategoriesSet
                               where categorie.Id == ID
                               select categorie;
            CategoriesSet objDishes = serveurQuery.Single();

            DB.CategoriesSet.Remove(objDishes);
            DB.SaveChanges();
        }

        public static void UpdateCategorie(String nom, int ID)
        {
            var serveurQuery = from categorie in DB.CategoriesSet
                               where categorie.Id == ID
                               select categorie;
            CategoriesSet objdriver = serveurQuery.Single();

            objdriver.Nom = nom;

            DB.SaveChanges();
        }

        public static List<CategoriesSet> listCategorie()
        {
            return DB.CategoriesSet.ToList<CategoriesSet>();

        }

        /*
         * Apelle base de donné concernant les Sections
         */
        public static void AddSections(int x, int y, int categorieId, int idemp)
        {
            SectionsSet newSection = new SectionsSet();
            newSection.X = x;
            newSection.Y = y;
            newSection.CategoriesId = categorieId;
            newSection.EmployeesId = idemp;


            DB.SectionsSet.Add(newSection);
            DB.SaveChanges();
        }

        public static void RemoveSections(int ID)
        {
            var serveurQuery = from section in DB.SectionsSet
                               where section.Id == ID
                               select section;
            SectionsSet objDishes = serveurQuery.Single();

            DB.SectionsSet.Remove(objDishes);
            DB.SaveChanges();
        }

        public static void UpdateSections(int x, int y, int categorieId, int employeeid, int ID)
        {
            var serveurQuery = from categorie in DB.SectionsSet
                               where categorie.Id == ID
                               select categorie;
            SectionsSet objdriver = serveurQuery.Single();

            objdriver.X = x;
            objdriver.Y = y;
            objdriver.CategoriesId = categorieId;
            objdriver.EmployeesId = employeeid;

            DB.SaveChanges();
        }

        public static List<SectionsSet> listSections()
        {
            return DB.SectionsSet.ToList<SectionsSet>();

        }


    }
}
