using System;

namespace com.vip.adp.api.open.service{
	
	
	public enum VipLinkTypeEnum {
		
		
		///<summary>
		/// 非法链接
		///</summary>
		ILLEGAL_LINK = -1, 
		
		///<summary>
		/// 非唯品会链接
		///</summary>
		NOT_VIPSHOP_LINK = 0, 
		
		///<summary>
		/// 商品
		///</summary>
		GOODS = 1, 
		
		///<summary>
		/// 专场
		///</summary>
		BRAND = 2, 
		
		///<summary>
		/// 唯品会其它链接
		///</summary>
		OTHER = 9 
	}
	
	public class VipLinkTypeEnumUtil{
		
		private readonly int value;
		private VipLinkTypeEnumUtil(int value){
			this.value = value;
		}
		
		public int getValue() {
			return value;
		}
		
		
		public static VipLinkTypeEnum? FindByValue(int value){
			
			switch(value){
				
				case -1: return VipLinkTypeEnum.ILLEGAL_LINK; 
				case 0: return VipLinkTypeEnum.NOT_VIPSHOP_LINK; 
				case 1: return VipLinkTypeEnum.GOODS; 
				case 2: return VipLinkTypeEnum.BRAND; 
				case 9: return VipLinkTypeEnum.OTHER; 
				
				default: return null; 
				
			}
			
		}
		
		public static VipLinkTypeEnum? FindByName(string name){
			
			if(VipLinkTypeEnum.ILLEGAL_LINK.ToString().Equals(name)){
				
				return VipLinkTypeEnum.ILLEGAL_LINK; 
			}
			
			if(VipLinkTypeEnum.NOT_VIPSHOP_LINK.ToString().Equals(name)){
				
				return VipLinkTypeEnum.NOT_VIPSHOP_LINK; 
			}
			
			if(VipLinkTypeEnum.GOODS.ToString().Equals(name)){
				
				return VipLinkTypeEnum.GOODS; 
			}
			
			if(VipLinkTypeEnum.BRAND.ToString().Equals(name)){
				
				return VipLinkTypeEnum.BRAND; 
			}
			
			if(VipLinkTypeEnum.OTHER.ToString().Equals(name)){
				
				return VipLinkTypeEnum.OTHER; 
			}
			
			
			return null;
			
		}
		
	}
	
}