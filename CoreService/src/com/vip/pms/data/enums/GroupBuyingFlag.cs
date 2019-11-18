using System;

namespace com.vip.pms.data.enums{
	
	
	public enum GroupBuyingFlag {
		
		
		///<summary>
		/// 拼团活动
		///</summary>
		GROUP_BUYING = 1, 
		
		///<summary>
		/// 非拼团活动
		///</summary>
		NON_GROUP_BUYING = 0 
	}
	
	public class GroupBuyingFlagUtil{
		
		private readonly int value;
		private GroupBuyingFlagUtil(int value){
			this.value = value;
		}
		
		public int getValue() {
			return value;
		}
		
		
		public static GroupBuyingFlag? FindByValue(int value){
			
			switch(value){
				
				case 1: return GroupBuyingFlag.GROUP_BUYING; 
				case 0: return GroupBuyingFlag.NON_GROUP_BUYING; 
				
				default: return null; 
				
			}
			
		}
		
		public static GroupBuyingFlag? FindByName(string name){
			
			if(GroupBuyingFlag.GROUP_BUYING.ToString().Equals(name)){
				
				return GroupBuyingFlag.GROUP_BUYING; 
			}
			
			if(GroupBuyingFlag.NON_GROUP_BUYING.ToString().Equals(name)){
				
				return GroupBuyingFlag.NON_GROUP_BUYING; 
			}
			
			
			return null;
			
		}
		
	}
	
}