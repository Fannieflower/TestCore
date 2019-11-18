using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.newretail{
	
	
	
	
	
	public class OrderDetail {
		
		///<summary>
		/// 订单编号
		///</summary>
		
		private string order_id_;
		
		///<summary>
		/// 发货仓库
		///</summary>
		
		private string warehouse_;
		
		///<summary>
		/// 出仓日期，单位：秒
		///</summary>
		
		private long? out_time_;
		
		///<summary>
		/// 商品信息列表
		///</summary>
		
		private List<com.vip.vop.cup.api.newretail.GoodsInfo> goods_infos_;
		
		public string GetOrder_id(){
			return this.order_id_;
		}
		
		public void SetOrder_id(string value){
			this.order_id_ = value;
		}
		public string GetWarehouse(){
			return this.warehouse_;
		}
		
		public void SetWarehouse(string value){
			this.warehouse_ = value;
		}
		public long? GetOut_time(){
			return this.out_time_;
		}
		
		public void SetOut_time(long? value){
			this.out_time_ = value;
		}
		public List<com.vip.vop.cup.api.newretail.GoodsInfo> GetGoods_infos(){
			return this.goods_infos_;
		}
		
		public void SetGoods_infos(List<com.vip.vop.cup.api.newretail.GoodsInfo> value){
			this.goods_infos_ = value;
		}
		
	}
	
}