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
            this.name = name;
            this.salePrice = salePrice;
            this.size = new Boolean[size.Length];
            merchID = ++amountOfMerch;
            if (size.Length > 0){
                this.size = new Boolean[amountOfSizes];
                for (int i = 0; i < amountOfSizes; i++){
                    if (size[i] == true){
                        this.size[i] = true;
                    }
                    else{
                        this.size[i] = false;
                    }
                }
            }
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