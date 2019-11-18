using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.order{
	
	
	
	
	
	public class OrderGoodsInfo {
		
		///<summary>
		/// 商品SkuId
		///</summary>
		
		private string prod_sku_id_;
		
		///<summary>
		/// 商品单价
		///</summary>
		
		private string price_;
		
		///<summary>
		/// 数量
		///</summary>
		
		private int? amount_;
		
		///<summary>
		/// 商品类型 0-普通商品 1-赠品,2-换购商品
		///</summary>
		
		private int? goods_type_;
		
		///<summary>
		/// 定价时间
		///</summary>
		
		private string price_time_;
		
		public string GetProd_sku_id(){
			return this.prod_sku_id_;
		}
		
		public void SetProd_sku_id(string value){
			this.prod_sku_id_ = value;
		}
		public string GetPrice(){
			return this.price_;
		}
		
		public void SetPrice(string value){
			this.price_ = value;
		}
		public int? GetAmount(){
			return this.amount_;
		}
		
		public void SetAmount(int? value){
			this.amount_ = value;
		}
		public int? GetGoods_type(){
			return this.goods_type_;
		}
		
		public void SetGoods_type(int? value){
			this.goods_type_ = value;
		}
		public string GetPrice_time(){
			return this.price_time_;
		}
		
		public void SetPrice_time(string value){
			this.price_time_ = value;
		}
		
	}
	
}