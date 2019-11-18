using System;

namespace com.vip.imp.otd.otdapi.service{
	
	
	public enum VopDeliveryChannelType {
		
		
		///<summary>
		/// 移动精选
		///</summary>
		VTD = 1, 
		
		///<summary>
		/// 腾讯广告
		///</summary>
		TSA = 2, 
		
		///<summary>
		/// 百度信息流
		///</summary>
		BDF = 3, 
		
		///<summary>
		/// 唯智展
		///</summary>
		ADS = 4 
	}
	
	public class VopDeliveryChannelTypeUtil{
		
		private readonly int value;
		private VopDeliveryChannelTypeUtil(int value){
			this.value = value;
		}
		
		public int getValue() {
			return value;
		}
		
		
		public static VopDeliveryChannelType? FindByValue(int value){
			
			switch(value){
				
				case 1: return VopDeliveryChannelType.VTD; 
				case 2: return VopDeliveryChannelType.TSA; 
				case 3: return VopDeliveryChannelType.BDF; 
				case 4: return VopDeliveryChannelType.ADS; 
				
				default: return null; 
				
			}
			
		}
		
		public static VopDeliveryChannelType? FindByName(string name){
			
			if(VopDeliveryChannelType.VTD.ToString().Equals(name)){
				
				return VopDeliveryChannelType.VTD; 
			}
			
			if(VopDeliveryChannelType.TSA.ToString().Equals(name)){
				
				return VopDeliveryChannelType.TSA; 
			}
			
			if(VopDeliveryChannelType.BDF.ToString().Equals(name)){
				
				return VopDeliveryChannelType.BDF; 
			}
			
			if(VopDeliveryChannelType.ADS.ToString().Equals(name)){
				
				return VopDeliveryChannelType.ADS; 
			}
			
			
			return null;
			
		}
		
	}
	
}