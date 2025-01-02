using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA{
    public partial class CodeSignal {
        public static string[][] groupingDishes(string[][] dishes){
            var values=new Dictionary<string, List<string>>();
            
            List<string> list = null;
            foreach (var dish in dishes)
                for (var i=1;i<dish.Length; i++)
                {
                    if (values.ContainsKey(dish[i])){
                        list=values[dish[i]];
                        list.Add(dish[0]);
                        values[dish[i]]=list;
                    }                      
                    else {
                        list = new List<string>();
                        list.Add(dish[i]);
                        list.Add(dish[0]);
                        values.Add(dish[i], list);
                    }             
                }

            var keys=values.Values.Select(val=>val.ToArray()).ToArray();
            return keys;           

        }

        public static void groupingDishesTests() {
            string[][] dishes = {
                new string[]{"salad", "tomato", "salad", "sauce"},
                new string[]{"pizza", "sauce", "aceituna", "pan", "carne"}
            };
            Helper.PrintArray(dishes);
            var result = groupingDishes(dishes);
            Helper.PrintArray(result);

        }
        
    }
}