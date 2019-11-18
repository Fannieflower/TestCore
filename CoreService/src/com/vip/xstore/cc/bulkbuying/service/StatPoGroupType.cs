using System;

namespace com.vip.xstore.cc.bulkbuying.service{
	
	
	public enum StatPoGroupType {
		
		
		
		BRAND = 0, 
		
		
		CATEGORY = 1, 
		
		
		SEASON = 2 
	}
	
	public class StatPoGroupTypeUtil{
		
		private readonly int value;
		private StatPoGroupTypeUtil(int value){
			this.value = value;
		}
		
		public int getValue() {
			return value;
		}
		
		
		public static StatPoGroupType? FindByValue(int value){
			
			switch(value){
				
				case 0: return StatPoGroupType.BRAND; 
				case 1: return StatPoGroupType.CATEGORY; 
				case 2: return StatPoGroupType.SEASON; 
				
				default: return null; 
				
			}
			
		}
		
		public static StatPoGroupType? FindByName(string name){
			
			if(StatPoGroupType.BRAND.ToString().Equals(name)){
				
				return StatPoGroupType.BRAND; 
			}
			
			if(StatPoGroupType.CATEGORY.ToString().Equals(name)){
				
				return StatPoGroupType.CATEGORY; 
			}
			
			if(StatPoGroupType.SEASON.ToString().Equals(name)){
				
				return StatPoGroupType.SEASON; 
			}
			
			
			return null;
			
		}
		
	}
	
}