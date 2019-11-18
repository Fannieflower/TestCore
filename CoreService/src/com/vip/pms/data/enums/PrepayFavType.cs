using System;

namespace com.vip.pms.data.enums{
	
	
	public enum PrepayFavType {
		
		
		///<summary>
		/// 比例
		///</summary>
		RATIO = 1, 
		
		///<summary>
		/// 现金
		///</summary>
		CASH = 2, 
		
		///<summary>
		/// 折扣
		///</summary>
		DISCOUNT = 3 
	}
	
	public class PrepayFavTypeUtil{
		
		private readonly int value;
		private PrepayFavTypeUtil(int value){
			this.value = value;
		}
		
		public int getValue() {
			return value;
		}
		
		
		public static PrepayFavType? FindByValue(int value){
			
			switch(value){
				
				case 1: return PrepayFavType.RATIO; 
				case 2: return PrepayFavType.CASH; 
				case 3: return PrepayFavType.DISCOUNT; 
				
				default: return null; 
				
			}
			
		}
		
		public static PrepayFavType? FindByName(string name){
			
			if(PrepayFavType.RATIO.ToString().Equals(name)){
				
				return PrepayFavType.RATIO; 
			}
			
			if(PrepayFavType.CASH.ToString().Equals(name)){
				
				return PrepayFavType.CASH; 
			}
			
			if(PrepayFavType.DISCOUNT.ToString().Equals(name)){
				
				return PrepayFavType.DISCOUNT; 
			}
			
			
			return null;
			
		}
		
	}
	
}