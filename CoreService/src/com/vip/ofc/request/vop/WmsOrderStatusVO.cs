using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.ofc.request.vop{
	
	
	
	
	
	public class WmsOrderStatusVO {
		
		///<summary>
		/// wms接口id
		/// @sampleValue id 格式为 仓库编码 + '_' + 自增id
		///</summary>
		
		private string id_;
		
		///<summary>
		/// 订单号
		///</summary>
		
		private string orderSn_;
		
		///<summary>
		/// 父单号
		///</summary>
		
		private string parentOrderSn_;
		
		///<summary>
		/// wms订单状态
		/// @sampleValue orderStatus 004:在库内,005:拣货中,006:缺货,016:ToB订单整单缺货,007:已OQC交接包含预付合包,030:RDC调拨收货 / JIT调拨收货,031:占位但未使用
		///</summary>
		
		private string orderStatus_;
		
		///<summary>
		/// 状态产生时间
		///</summary>
		
		private long? updateTime_;
		
		///<summary>
		/// 创建时间,格式YYYY-MM-DD HH:mm:ss
		///</summary>
		
		private string createTime_;
		
		///<summary>
		/// 备注
		///</summary>
		
		private string memo_;
		
		public string GetId(){
			return this.id_;
		}
		
		public void SetId(string value){
			this.id_ = value;
		}
		public string GetOrderSn(){
			return this.orderSn_;
		}
		
		public void SetOrderSn(string value){
			this.orderSn_ = value;
		}
		public string GetParentOrderSn(){
			return this.parentOrderSn_;
		}
		
		public void SetParentOrderSn(string value){
			this.parentOrderSn_ = value;
		}
		public string GetOrderStatus(){
			return this.orderStatus_;
		}
		
		public void SetOrderStatus(string value){
			this.orderStatus_ = value;
		}
		public long? GetUpdateTime(){
			return this.updateTime_;
		}
		
		public void SetUpdateTime(long? value){
			this.updateTime_ = value;
		}
		public string GetCreateTime(){
			return this.createTime_;
		}
		
		public void SetCreateTime(string value){
			this.createTime_ = value;
		}
		public string GetMemo(){
			return this.memo_;
		}
		
		public void SetMemo(string value){
			this.memo_ = value;
		}
		
	}
	
}