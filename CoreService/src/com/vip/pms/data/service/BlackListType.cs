using System;

namespace com.vip.pms.data.service{
	
	
	public enum BlackListType {
		
		
		///<summary>
		/// 档期（专场）
		///</summary>
		BRAND = 1, 
		
		///<summary>
		/// 品牌sn
		///</summary>
		BRAND_STORE_SN = 2, 
		
		///<summary>
		/// 三级录入分类id
		///</summary>
		CATEGORY_ID = 3 
	}
	
	public class BlackListTypeUtil{
		
		private readonly int value;
		private BlackListTypeUtil(int value){
			this.value = value;
		}
		
		public int getValue() {
			return value;
		}
		
		
		public static BlackListType? FindByValue(int value){
			
			switch(value){
				
				case 1: return BlackListType.BRAND; 
				case 2: return BlackListType.BRAND_STORE_SN; 
				case 3: return BlackListType.CATEGORY_ID; 
				
				default: return null; 
				
			}
			
		}
		
		public static BlackListType? FindByName(string name){
			
			if(BlackListType.BRAND.ToString().Equals(name)){
				
				return BlackListType.BRAND; 
			}
			
			if(BlackListType.BRAND_STORE_SN.ToString().Equals(name)){
				
				return BlackListType.BRAND_STORE_SN; 
			}
			
			if(BlackListType.CATEGORY_ID.ToString().Equals(name)){
				
				return BlackListType.CATEGORY_ID; 
			}
			
			
			return null;
			
		}
		
	}
	
}