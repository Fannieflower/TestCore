using System;

namespace vipapis.marketplace.delivery{
	
	
	public enum DecryptExtendKey {
		
		
		///<summary>
		/// 解密业务类型（如发货、定向营销、用户回访等）
		///</summary>
		BUSINESS_TYPE = 0, 
		
		///<summary>
		/// 客户端浏览器user agent
		///</summary>
		USER_AGENT = 1, 
		
		///<summary>
		/// 客户端程序名称及版本号
		///</summary>
		USER_CLIENT = 2, 
		
		///<summary>
		/// 客户端ip
		///</summary>
		USER_IP = 3 
	}
	
	public class DecryptExtendKeyUtil{
		
		private readonly int value;
		private DecryptExtendKeyUtil(int value){
			this.value = value;
		}
		
		public int getValue() {
			return value;
		}
		
		
		public static DecryptExtendKey? FindByValue(int value){
			
			switch(value){
				
				case 0: return DecryptExtendKey.BUSINESS_TYPE; 
				case 1: return DecryptExtendKey.USER_AGENT; 
				case 2: return DecryptExtendKey.USER_CLIENT; 
				case 3: return DecryptExtendKey.USER_IP; 
				
				default: return null; 
				
			}
			
		}
		
		public static DecryptExtendKey? FindByName(string name){
			
			if(DecryptExtendKey.BUSINESS_TYPE.ToString().Equals(name)){
				
				return DecryptExtendKey.BUSINESS_TYPE; 
			}
			
			if(DecryptExtendKey.USER_AGENT.ToString().Equals(name)){
				
				return DecryptExtendKey.USER_AGENT; 
			}
			
			if(DecryptExtendKey.USER_CLIENT.ToString().Equals(name)){
				
				return DecryptExtendKey.USER_CLIENT; 
			}
			
			if(DecryptExtendKey.USER_IP.ToString().Equals(name)){
				
				return DecryptExtendKey.USER_IP; 
			}
			
			
			return null;
			
		}
		
	}
	
}