using System;

namespace com.vip.venus.po.service{
	
	
	public enum Owner {
		
		
		
		BUSINESS_PURCHASE = 0, 
		
		
		GROUP_PURCHASE = 1 
	}
	
	public class OwnerUtil{
		
		private readonly int value;
		private OwnerUtil(int value){
			this.value = value;
		}
		
		public int getValue() {
			return value;
		}
		
		
		public static Owner? FindByValue(int value){
			
			switch(value){
				
				case 0: return Owner.BUSINESS_PURCHASE; 
				case 1: return Owner.GROUP_PURCHASE; 
				
				default: return null; 
				
			}
			
		}
		
		public static Owner? FindByName(string name){
			
			if(Owner.BUSINESS_PURCHASE.ToString().Equals(name)){
				
				return Owner.BUSINESS_PURCHASE; 
			}
			
			if(Owner.GROUP_PURCHASE.ToString().Equals(name)){
				
				return Owner.GROUP_PURCHASE; 
			}
			
			
			return null;
			
		}
		
	}
	
}