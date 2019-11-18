using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.marketplace.asc{
	
	
	
	
	
	public class AscProduct {
		
		///<summary>
		/// 退货明细id
		///</summary>
		
		private string asc_product_id_;
		
		///<summary>
		/// 商品id
		///</summary>
		
		private string sku_id_;
		
		///<summary>
		/// 商品名称
		///</summary>
		
		private string good_name_;
		
		///<summary>
		/// 数量
		///</summary>
		
		private int? quantity_;
		
		///<summary>
		/// 单个商品优惠金额
		///</summary>
		
		private double? goods_fav_;
		
		///<summary>
		/// 单价
		///</summary>
		
		private double? price_;
		
		///<summary>
		/// 退货原因
		///</summary>
		
		private string return_reason_;
		
		///<summary>
		/// 尺码
		///</summary>
		
		private string unit_;
		
		///<summary>
		/// 退货明细单状态：0 待审核，1 审核通过，2 审核不通过，3 已同意退款，4 已拒绝退款
		///</summary>
		
		private string asc_product_status_;
		
		public string GetAsc_product_id(){
			return this.asc_product_id_;
		}
		
		public void SetAsc_product_id(string value){
			this.asc_product_id_ = value;
		}
		public string GetSku_id(){
			return this.sku_id_;
		}
		
		public void SetSku_id(string value){
			this.sku_id_ = value;
		}
		public string GetGood_name(){
			return this.good_name_;
		}
		
		public void SetGood_name(string value){
			this.good_name_ = value;
		}
		public int? GetQuantity(){
			return this.quantity_;
		}
		
		public void SetQuantity(int? value){
			this.quantity_ = value;
		}
		public double? GetGoods_fav(){
			return this.goods_fav_;
		}
		
		public void SetGoods_fav(double? value){
			this.goods_fav_ = value;
		}
		public double? GetPrice(){
			return this.price_;
		}
		
		public void SetPrice(double? value){
			this.price_ = value;
		}
		public string GetReturn_reason(){
			return this.return_reason_;
		}
		
		public void SetReturn_reason(string value){
			this.return_reason_ = value;
		}
		public string GetUnit(){
			return this.unit_;
		}
		
		public void SetUnit(string value){
			this.unit_ = value;
		}
		public string GetAsc_product_status(){
			return this.asc_product_status_;
		}
		
		public void SetAsc_product_status(string value){
			this.asc_product_status_ = value;
		}
		
	}
	
}