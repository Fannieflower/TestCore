using System;

namespace vipapis.xstore.cc.sims.erp{
	
	
	public enum RspCodeEnum {
		
		
		///<summary>
		/// 成功
		///</summary>
		SUCCESS = 200, 
		
		///<summary>
		/// 系统异常
		///</summary>
		SYSTEM_ERROR = 500, 
		
		///<summary>
		/// 剩余库存不足
		///</summary>
		INSUFFICIENT_INVENTORY = 300, 
		
		///<summary>
		/// 参数错误
		///</summary>
		PARAM_ERROR = 301 
	}
	
	public class RspCodeEnumUtil{
		
		private readonly int value;
		private RspCodeEnumUtil(int value){
			this.value = value;
		}
		
		public int getValue() {
			return value;
		}
		
		
		public static RspCodeEnum? FindByValue(int value){
			
			switch(value){
				
				case 200: return RspCodeEnum.SUCCESS; 
				case 500: return RspCodeEnum.SYSTEM_ERROR; 
				case 300: return RspCodeEnum.INSUFFICIENT_INVENTORY; 
				case 301: return RspCodeEnum.PARAM_ERROR; 
				
				default: return null; 
				
			}
			
		}
		
		public static RspCodeEnum? FindByName(string name){
			
			if(RspCodeEnum.SUCCESS.ToString().Equals(name)){
				
				return RspCodeEnum.SUCCESS; 
			}
			
			if(RspCodeEnum.SYSTEM_ERROR.ToString().Equals(name)){
				
				return RspCodeEnum.SYSTEM_ERROR; 
			}
			
			if(RspCodeEnum.INSUFFICIENT_INVENTORY.ToString().Equals(name)){
				
				return RspCodeEnum.INSUFFICIENT_INVENTORY; 
			}
			
			if(RspCodeEnum.PARAM_ERROR.ToString().Equals(name)){
				
				return RspCodeEnum.PARAM_ERROR; 
			}
			
			
			return null;
			
		}
		
	}
	
}