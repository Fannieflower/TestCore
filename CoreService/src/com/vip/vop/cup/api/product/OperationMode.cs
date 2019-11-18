using System;

namespace com.vip.vop.cup.api.product{
	
	
	public enum OperationMode {
		
		
		///<summary>
		/// 添加
		///</summary>
		ADD = 0, 
		
		///<summary>
		/// 更新
		///</summary>
		UPDATE = 1, 
		
		///<summary>
		/// 删除
		///</summary>
		DELETE = 2 
	}
	
	public class OperationModeUtil{
		
		private readonly int value;
		private OperationModeUtil(int value){
			this.value = value;
		}
		
		public int getValue() {
			return value;
		}
		
		
		public static OperationMode? FindByValue(int value){
			
			switch(value){
				
				case 0: return OperationMode.ADD; 
				case 1: return OperationMode.UPDATE; 
				case 2: return OperationMode.DELETE; 
				
				default: return null; 
				
			}
			
		}
		
		public static OperationMode? FindByName(string name){
			
			if(OperationMode.ADD.ToString().Equals(name)){
				
				return OperationMode.ADD; 
			}
			
			if(OperationMode.UPDATE.ToString().Equals(name)){
				
				return OperationMode.UPDATE; 
			}
			
			if(OperationMode.DELETE.ToString().Equals(name)){
				
				return OperationMode.DELETE; 
			}
			
			
			return null;
			
		}
		
	}
	
}