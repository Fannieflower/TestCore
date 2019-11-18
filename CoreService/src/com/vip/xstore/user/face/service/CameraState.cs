using System;

namespace com.vip.xstore.user.face.service{
	
	
	public enum CameraState {
		
		
		
		NORMAL = 0, 
		
		
		ABNORMAL = 1, 
		
		
		ALL = 2 
	}
	
	public class CameraStateUtil{
		
		private readonly int value;
		private CameraStateUtil(int value){
			this.value = value;
		}
		
		public int getValue() {
			return value;
		}
		
		
		public static CameraState? FindByValue(int value){
			
			switch(value){
				
				case 0: return CameraState.NORMAL; 
				case 1: return CameraState.ABNORMAL; 
				case 2: return CameraState.ALL; 
				
				default: return null; 
				
			}
			
		}
		
		public static CameraState? FindByName(string name){
			
			if(CameraState.NORMAL.ToString().Equals(name)){
				
				return CameraState.NORMAL; 
			}
			
			if(CameraState.ABNORMAL.ToString().Equals(name)){
				
				return CameraState.ABNORMAL; 
			}
			
			if(CameraState.ALL.ToString().Equals(name)){
				
				return CameraState.ALL; 
			}
			
			
			return null;
			
		}
		
	}
	
}