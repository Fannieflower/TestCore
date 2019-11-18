using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.adp.api.open.service{
	
	
	
	
	
	public class VipLinkCheckVO {
		
		///<summary>
		/// 链接类型
		///</summary>
		
		private com.vip.adp.api.open.service.VipLinkTypeEnum? linkType_;
		
		///<summary>
		/// 落地页url
		///</summary>
		
		private string landUrl_;
		
		///<summary>
		/// 商品id
		///</summary>
		
		private string goodsId_;
		
		///<summary>
		/// 专场id
		///</summary>
		
		private string brandId_;
		
		public com.vip.adp.api.open.service.VipLinkTypeEnum? GetLinkType(){
			return this.linkType_;
		}
		
		public void SetLinkType(com.vip.adp.api.open.service.VipLinkTypeEnum? value){
			this.linkType_ = value;
		}
		public string GetLandUrl(){
			return this.landUrl_;
		}
		
		public void SetLandUrl(string value){
			this.landUrl_ = value;
		}
		public string GetGoodsId(){
			return this.goodsId_;
		}
		
		public void SetGoodsId(string value){
			this.goodsId_ = value;
		}
		public string GetBrandId(){
			return this.brandId_;
		}
		
		public void SetBrandId(string value){
			this.brandId_ = value;
		}
		
	}
	
}