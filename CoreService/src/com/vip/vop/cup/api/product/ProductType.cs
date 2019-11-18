using System;

namespace com.vip.vop.cup.api.product{
	
	
	public enum ProductType {
		
		
		///<summary>
		/// 销售商品主键是SPU维度
		///</summary>
		SPU = 0, 
		
		///<summary>
		/// 销售商品主键是SKU维度
		///</summary>
		SKU = 1 
	}
	
	public class ProductTypeUtil{
		
		private readonly int value;
		private ProductTypeUtil(int value){
			this.value = value;
		}
		
		public int getValue() {
			return value;
		}
		
		
		public static ProductType? FindByValue(int value){
			
			switch(value){
				
				case 0: return ProductType.SPU; 
				case 1: return ProductType.SKU; 
				
				default: return null; 
				
			}
			
		}
		
		public static ProductType? FindByName(string name){
			
			if(ProductType.SPU.ToString().Equals(name)){
				
				return ProductType.SPU; 
			}
			
			if(ProductType.SKU.ToString().Equals(name)){
				
				return ProductType.SKU; 
			}
			
			
			return null;
			
		}
		
	}
	
}