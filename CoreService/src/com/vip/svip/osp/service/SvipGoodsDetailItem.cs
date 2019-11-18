using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.svip.osp.service{
	
	
	
	
	
	public class SvipGoodsDetailItem {
		
		///<summary>
		/// 专场id
		///</summary>
		
		private string brandId_;
		
		///<summary>
		/// 专场名称
		///</summary>
		
		private string brandName_;
		
		///<summary>
		/// 品牌logo
		///</summary>
		
		private string brandLogo_;
		
		///<summary>
		/// 商品id
		///</summary>
		
		private string goodsId_;
		
		///<summary>
		/// 商品名称
		///</summary>
		
		private string goodsName_;
		
		///<summary>
		/// 商品图
		///</summary>
		
		private string goodsImg_;
		
		///<summary>
		/// 唯品价
		///</summary>
		
		private string vipPrice_;
		
		///<summary>
		/// svip价格
		///</summary>
		
		private string svipPrice_;
		
		///<summary>
		/// 是否多sku不同价
		///</summary>
		
		private bool? skuMultiPrice_;
		
		///<summary>
		/// 是否混合专场
		///</summary>
		
		private bool? multiBrand_;
		
		///<summary>
		/// 专场状态: 0-预热 1-在售
		///</summary>
		
		private int? salesState_;
		
		public string GetBrandId(){
			return this.brandId_;
		}
		
		public void SetBrandId(string value){
			this.brandId_ = value;
		}
		public string GetBrandName(){
			return this.brandName_;
		}
		
		public void SetBrandName(string value){
			this.brandName_ = value;
		}
		public string GetBrandLogo(){
			return this.brandLogo_;
		}
		
		public void SetBrandLogo(string value){
			this.brandLogo_ = value;
		}
		public string GetGoodsId(){
			return this.goodsId_;
		}
		
		public void SetGoodsId(string value){
			this.goodsId_ = value;
		}
		public string GetGoodsName(){
			return this.goodsName_;
		}
		
		public void SetGoodsName(string value){
			this.goodsName_ = value;
		}
		public string GetGoodsImg(){
			return this.goodsImg_;
		}
		
		public void SetGoodsImg(string value){
			this.goodsImg_ = value;
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
		public bool? GetSkuMultiPrice(){
			return this.skuMultiPrice_;
		}
		
		public void SetSkuMultiPrice(bool? value){
			this.skuMultiPrice_ = value;
		}
		public bool? GetMultiBrand(){
			return this.multiBrand_;
		}
		
		public void SetMultiBrand(bool? value){
			this.multiBrand_ = value;
		}
		public int? GetSalesState(){
			return this.salesState_;
		}
		
		public void SetSalesState(int? value){
			this.salesState_ = value;
		}
		
	}
	
}