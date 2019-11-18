using System;

namespace com.vip.venus.visPo.service{
	
	
	public enum SyncWmsStatus {
		
		
		///<summary>
		/// 0未同步
		///</summary>
		DEFAULT_STATUS = 0, 
		
		///<summary>
		/// 1已绑定地址
		///</summary>
		IS_BIND_ADDRESS = 1, 
		
		///<summary>
		/// 2已推送wms
		///</summary>
		PUSHED_WMS_SUCCESS = 2, 
		
		///<summary>
		/// 3推送失败
		///</summary>
		PUSHED_WMS__FAIL = 3 
	}
	
	public class SyncWmsStatusUtil{
		
		private readonly int value;
		private SyncWmsStatusUtil(int value){
			this.value = value;
		}
		
		public int getValue() {
			return value;
		}
		
		
		public static SyncWmsStatus? FindByValue(int value){
			
			switch(value){
				
				case 0: return SyncWmsStatus.DEFAULT_STATUS; 
				case 1: return SyncWmsStatus.IS_BIND_ADDRESS; 
				case 2: return SyncWmsStatus.PUSHED_WMS_SUCCESS; 
				case 3: return SyncWmsStatus.PUSHED_WMS__FAIL; 
				
				default: return null; 
				
			}
			
		}
		
		public static SyncWmsStatus? FindByName(string name){
			
			if(SyncWmsStatus.DEFAULT_STATUS.ToString().Equals(name)){
				
				return SyncWmsStatus.DEFAULT_STATUS; 
			}
			
			if(SyncWmsStatus.IS_BIND_ADDRESS.ToString().Equals(name)){
				
				return SyncWmsStatus.IS_BIND_ADDRESS; 
			}
			
			if(SyncWmsStatus.PUSHED_WMS_SUCCESS.ToString().Equals(name)){
				
				return SyncWmsStatus.PUSHED_WMS_SUCCESS; 
			}
			
			if(SyncWmsStatus.PUSHED_WMS__FAIL.ToString().Equals(name)){
				
				return SyncWmsStatus.PUSHED_WMS__FAIL; 
			}
			
			
			return null;
			
		}
		
	}
	
}