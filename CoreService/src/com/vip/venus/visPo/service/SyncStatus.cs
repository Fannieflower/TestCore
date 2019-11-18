using System;

namespace com.vip.venus.visPo.service{
	
	
	public enum SyncStatus {
		
		
		///<summary>
		/// 0未同步
		///</summary>
		DEFAULT_STATUS = 0, 
		
		///<summary>
		/// 1同步成功
		///</summary>
		SYNC_SUCCESS = 1, 
		
		///<summary>
		/// 2同步失败
		///</summary>
		SYNC_FAIL = 2, 
		
		///<summary>
		/// 6不需要同步的任务
		///</summary>
		NOT_NEED_SYNC = 6 
	}
	
	public class SyncStatusUtil{
		
		private readonly int value;
		private SyncStatusUtil(int value){
			this.value = value;
		}
		
		public int getValue() {
			return value;
		}
		
		
		public static SyncStatus? FindByValue(int value){
			
			switch(value){
				
				case 0: return SyncStatus.DEFAULT_STATUS; 
				case 1: return SyncStatus.SYNC_SUCCESS; 
				case 2: return SyncStatus.SYNC_FAIL; 
				case 6: return SyncStatus.NOT_NEED_SYNC; 
				
				default: return null; 
				
			}
			
		}
		
		public static SyncStatus? FindByName(string name){
			
			if(SyncStatus.DEFAULT_STATUS.ToString().Equals(name)){
				
				return SyncStatus.DEFAULT_STATUS; 
			}
			
			if(SyncStatus.SYNC_SUCCESS.ToString().Equals(name)){
				
				return SyncStatus.SYNC_SUCCESS; 
			}
			
			if(SyncStatus.SYNC_FAIL.ToString().Equals(name)){
				
				return SyncStatus.SYNC_FAIL; 
			}
			
			if(SyncStatus.NOT_NEED_SYNC.ToString().Equals(name)){
				
				return SyncStatus.NOT_NEED_SYNC; 
			}
			
			
			return null;
			
		}
		
	}
	
}