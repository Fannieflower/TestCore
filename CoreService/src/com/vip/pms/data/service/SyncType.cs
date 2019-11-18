using System;

namespace com.vip.pms.data.service{
	
	
	public enum SyncType {
		
		
		
		ADD = 0, 
		
		
		DELETE = 1 
	}
	
	public class SyncTypeUtil{
		
		private readonly int value;
		private SyncTypeUtil(int value){
			this.value = value;
		}
		
		public int getValue() {
			return value;
		}
		
		
		public static SyncType? FindByValue(int value){
			
			switch(value){
				
				case 0: return SyncType.ADD; 
				case 1: return SyncType.DELETE; 
				
				default: return null; 
				
			}
			
		}
		
		public static SyncType? FindByName(string name){
			
			if(SyncType.ADD.ToString().Equals(name)){
				
				return SyncType.ADD; 
			}
			
			if(SyncType.DELETE.ToString().Equals(name)){
				
				return SyncType.DELETE; 
			}
			
			
			return null;
			
		}
		
	}
	
}