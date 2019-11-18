using System;

namespace com.vip.vop.cup.api.product{
	
	
	public enum AttributeType {
		
		
		///<summary>
		/// 商品属性
		///</summary>
		NORMAL = 0, 
		
		///<summary>
		/// 商品标签
		///</summary>
		TAG = 1, 
		
		///<summary>
		/// 分类特有属性
		///</summary>
		SPECIAL = 2 
	}
	
	public class AttributeTypeUtil{
		
		private readonly int value;
		private AttributeTypeUtil(int value){
			this.value = value;
		}
		
		public int getValue() {
			return value;
		}
		
		
		public static AttributeType? FindByValue(int value){
			
			switch(value){
				
				case 0: return AttributeType.NORMAL; 
				case 1: return AttributeType.TAG; 
				case 2: return AttributeType.SPECIAL; 
				
				default: return null; 
				
			}
			
		}
		
		public static AttributeType? FindByName(string name){
			
			if(AttributeType.NORMAL.ToString().Equals(name)){
				
				return AttributeType.NORMAL; 
			}
			
			if(AttributeType.TAG.ToString().Equals(name)){
				
				return AttributeType.TAG; 
			}
			
			if(AttributeType.SPECIAL.ToString().Equals(name)){
				
				return AttributeType.SPECIAL; 
			}
			
			
			return null;
			
		}
		
	}
	
}