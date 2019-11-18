using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.svip.osp.service{
	
	
	
	
	
	public class SvipGoodsBPInfo {
		
		///<summary>
		/// 品牌名称
		///</summary>
		
		private string brandName_;
		
		///<summary>
		/// 商品名称
		///</summary>
		
		private string goodsName_;
		
		///<summary>
		/// 商品图片
		///</summary>
		
		private string imgUrl_;
		
		///<summary>
		/// 唯品价格
		///</summary>
		
		private string vipPrice_;
		
		///<summary>
		/// svip价格
		///</summary>
		
		private string svipPrice_;
		
		///<summary>
		/// 差额
		///</summary>
		
		private string diff_;
		
		///<summary>
		/// 是否不同sku不同价
		///</summary>
		
		private bool? skuMultiplePrice_;
		
		public string GetBrandName(){
			return this.brandName_;
		}
		
		public void SetBrandName(string value){
			this.brandName_ = value;
		}
		public string GetGoodsName(){
			return this.goodsName_;
		}
		
		public void SetGoodsName(string value){
			this.goodsName_ = value;
		}
		public string GetImgUrl(){
			return this.imgUrl_;
		}
		
		public void SetImgUrl(string value){
			this.imgUrl_ = value;
		}
		public string GetVipPrice(){
			return this.vipPrice_;
		}
		
		public void SetVipPrice(string value){
			this.vipPrice_ = value;
		}
		public string GetSvipPrice(){
			return this.svipPrice_;
		}
		
		public void SetSvipPrice(string value){
			this.svipPrice_ = value;
		}
		public string GetDiff(){
			return this.diff_;
		}
		
		public void SetDiff(string value){
			this.diff_ = value;
		}
		public bool? GetSkuMultiplePrice(){
			return this.skuMultiplePrice_;
		}
		
		public void SetSkuMultiplePrice(bool? value){
			this.skuMultiplePrice_ = value;
		}
		
	}
	
}