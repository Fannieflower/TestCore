using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.order{
	
	
	
	
	
	public class OxoOrderReturnApply {
		
		///<summary>
		/// 客退申请单编号
		///</summary>
		
		private string apply_id_;
		
		///<summary>
		/// 客退申请时间
		///</summary>
		
		private string apply_time_;
		
		///<summary>
		/// 退货运单号
		///</summary>
		
		private string transportNo_;
		
		///<summary>
		/// 客退快递承运商
		///</summary>
		
		private string carrier_;
		
		///<summary>
		/// 货退返回方式，0-自行寄回，2-上门取件。默认0
		///</summary>
		
		private int? goodsBackWay_;
		
		public string GetApply_id(){
			return this.apply_id_;
		}
		
		public void SetApply_id(string value){
			this.apply_id_ = value;
		}
		public string GetApply_time(){
			return this.apply_time_;
		}
		
		public void SetApply_time(string value){
			this.apply_time_ = value;
		}
		public string GetTransportNo(){
			return this.transportNo_;
		}
		
		public void SetTransportNo(string value){
			this.transportNo_ = value;
		}
		public string GetCarrier(){
			return this.carrier_;
		}
		
		public void SetCarrier(string value){
			this.carrier_ = value;
		}
		public int? GetGoodsBackWay(){
			return this.goodsBackWay_;
		}
		
		public void SetGoodsBackWay(int? value){
			this.goodsBackWay_ = value;
		}
		
	}
	
}