using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.newretail{
	
	
	
	
	
	public class AfterSaleDetail {
		
		///<summary>
		/// 订单编号
		///</summary>
		
		private string order_id_;
		
		///<summary>
		/// 售后申请单号
		///</summary>
		
		private long? apply_id_;
		
		///<summary>
		/// 是否退实物,0 是 1 否
		///</summary>
		
		private byte? is_return_goods_;
		
		///<summary>
		/// 生成日期,单位：秒
		///</summary>
		
		private long? create_time_;
		
		///<summary>
		/// 商品列表
		///</summary>
		
		private List<com.vip.vop.cup.api.newretail.GoodsInfo> goods_infos_;
		
		public string GetOrder_id(){
			return this.order_id_;
		}
		
		public void SetOrder_id(string value){
			this.order_id_ = value;
		}
		public long? GetApply_id(){
			return this.apply_id_;
		}
		
		public void SetApply_id(long? value){
			this.apply_id_ = value;
		}
		public byte? GetIs_return_goods(){
			return this.is_return_goods_;
		}
		
		public void SetIs_return_goods(byte? value){
			this.is_return_goods_ = value;
		}
		public long? GetCreate_time(){
			return this.create_time_;
		}
		
		public void SetCreate_time(long? value){
			this.create_time_ = value;
		}
		public List<com.vip.vop.cup.api.newretail.GoodsInfo> GetGoods_infos(){
			return this.goods_infos_;
		}
		
		public void SetGoods_infos(List<com.vip.vop.cup.api.newretail.GoodsInfo> value){
			this.goods_infos_ = value;
		}
		
	}
	
}