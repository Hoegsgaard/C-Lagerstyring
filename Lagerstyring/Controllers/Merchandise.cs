using System;

namespace Lagerstyring.Controllers{
    public class Merchandise{
        private int amountOfSizes = 10;
        private int amountOfMerch = countAmountOfMerch();
        
        private String name;
        private double salePrice;
        private Boolean[] size;
        private int antal = 0;
        private int merchID;

        public Merchandise(String name, double salePrice, Boolean[] size){
            merchID = ++amountOfMerch;
            this.name = name;
            this.salePrice = salePrice;
            this.size = new Boolean[size.Length];
            if (size.Length > 0){
                this.size = new Boolean[amountOfSizes];
                this.size = size;
            }
            
            saveToStock();
        }

        public void saveToStock(){
            
        }

        public static int countAmountOfMerch(){
            
            return 0;
        }

        public double calculateAverageProfit(int merchType){
            double average = 0;

            return average;
        }

        public double calculateTotalIncome(int merchType){
            double totalIncome = 0;

            return totalIncome;
        }

        public double calculateTotalExpense(int merchType){
            double totalExpense = 0;

            return totalExpense;
        }
        
        public double calculateTotalProfit(int merchType){
            return calculateTotalIncome(merchType) - calculateTotalExpense(merchType);
        }

        public void editStock(int merchType, int antal, string description){
            
        }




        //Getter og Setter
        public string Name{
            get => name;
            set => name = value;
        }
        public double SalePrice{
            get => salePrice;
            set => salePrice = value;
        }
        public Boolean[] Size{
            get => size;
            set => size = value;
        }
        public int Antal{
            get => antal;
            set => antal = value;
        }
        
    }
}