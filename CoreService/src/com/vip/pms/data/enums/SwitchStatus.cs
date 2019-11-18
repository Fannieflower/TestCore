using System;

namespace com.vip.pms.data.enums{
	
	
	public enum SwitchStatus {
		
		
		///<summary>
		/// 打开状态
		///</summary>
		ON = 1, 
		
		///<summary>
		/// 关闭状态
		///</summary>
		OFF = 0 
	}
	
	public class SwitchStatusUtil{
		
		private readonly int value;
		private SwitchStatusUtil(int value){
			this.value = value;
		}
		
		public int getValue() {
			return value;
		}
		
		
		public static SwitchStatus? FindByValue(int value){
			
			switch(value){
				
				case 1: return SwitchStatus.ON; 
				case 0: return SwitchStatus.OFF; 
				
				default: return null; 
				
			}
			
		}
		
		public static SwitchStatus? FindByName(string name){
			
			if(SwitchStatus.ON.ToString().Equals(name)){
				
				return SwitchStatus.ON; 
			}
			
			if(SwitchStatus.OFF.ToString().Equals(name)){
				
				return SwitchStatus.OFF; 
			}
			
			
			return null;
			
		}
		
	}
	
}