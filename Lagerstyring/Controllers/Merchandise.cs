using System;

namespace Lagerstyring.Controllers{
    public class Merchandise{
        private int amountOfSizes = 10;
        
        private String name;
        private double salePrice;
        private Boolean[] size;
        private int antal = 0;

        public Merchandise(String name, double salePrice, Boolean[] size){
            this.name = name;
            this.salePrice = salePrice;
            this.size = new Boolean[size.Length];
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