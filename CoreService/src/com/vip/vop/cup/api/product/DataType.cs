using System;

namespace com.vip.vop.cup.api.product{
	
	
	public enum DataType {
		
		
		///<summary>
		/// 自由文本，约定不包括英文标点符号
		///</summary>
		TEXT = 0, 
		
		///<summary>
		/// 数值类型
		///</summary>
		NUMERIC = 1, 
		
		///<summary>
		/// 选项类型
		///</summary>
		OPTION = 2, 
		
		///<summary>
		/// 布尔类型
		///</summary>
		BUMBLE = 3, 
		
		///<summary>
		/// 图片类型
		///</summary>
		PICTURE = 4 
	}
	
	public class DataTypeUtil{
		
		private readonly int value;
		private DataTypeUtil(int value){
			this.value = value;
		}
		
		public int getValue() {
			return value;
		}
		
		
		public static DataType? FindByValue(int value){
			
			switch(value){
				
				case 0: return DataType.TEXT; 
				case 1: return DataType.NUMERIC; 
				case 2: return DataType.OPTION; 
				case 3: return DataType.BUMBLE; 
				case 4: return DataType.PICTURE; 
				
				default: return null; 
				
			}
			
		}
		
		public static DataType? FindByName(string name){
			
			if(DataType.TEXT.ToString().Equals(name)){
				
				return DataType.TEXT; 
			}
			
			if(DataType.NUMERIC.ToString().Equals(name)){
				
				return DataType.NUMERIC; 
			}
			
			if(DataType.OPTION.ToString().Equals(name)){
				
				return DataType.OPTION; 
			}
			
			if(DataType.BUMBLE.ToString().Equals(name)){
				
				return DataType.BUMBLE; 
			}
			
			if(DataType.PICTURE.ToString().Equals(name)){
				
				return DataType.PICTURE; 
			}
			
			
			return null;
			
		}
		
	}
	
}