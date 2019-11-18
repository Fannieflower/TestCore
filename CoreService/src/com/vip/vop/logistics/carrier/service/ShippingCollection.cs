using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.logistics.carrier.service{
	
	
	
	
	
	public class ShippingCollection {
		
		///<summary>
		/// 运单号
		///</summary>
		
		private string logistics_no_;
		
		///<summary>
		/// 交易id，唯品会交易id
		///</summary>
		
		private string trade_id_;
		
		///<summary>
		/// 操作联系人信息，条件必填
		///</summary>
		
		private com.vip.vop.logistics.Linkman linkman_;
		
		///<summary>
		/// 操作：<br/>ACCEPT=承运商接单，<br/>DISPATCH=承运商安排揽收快递员，<br/>VISIT_DOOR=快递员准备上门揽件，<br/> COLLECT_SUCCEED=揽件成功，<br/>COLLECT_FAILED=揽件失败，<br/>COLLECT_ERROR=揽件异常
		///</summary>
		
		private string action_;
		
		///<summary>
		/// 操作时间
		///</summary>
		
		private System.DateTime? op_time_;
		
		///<summary>
		/// 失败或者异常原因，条件必填。揽件失败时填：<br/>3601=客户表示自退<br/>3602=客户表示自留拒退<br/>3603=唯品会通知取消揽件<br/>3604=超出7天揽件时效<br/>3605=商品不符合质检要求<br/>3606=客户拒绝支持应收运费<br/>3607=无货揽退（客户拒收退货）<br/>3608=客户退货与揽件单明细不符<br/>3609=退货原因与质检原因不一致<br/>3610=其它原因<br/>揽件异常时填：<br/>404=天气异常<br/>405=站点延误揽收<br/>406=联系不上寄件人<br/>407=寄件人不在揽件地址<br/>408=寄件人更改揽件时间<br/>409=寄件人更改揽件信息
		///</summary>
		
		private string reasonType_;
		
		///<summary>
		/// 包裹信息，条件必填
		///</summary>
		
		private com.vip.vop.logistics.carrier.service.CollectionPacket packet_;
		
		public string GetLogistics_no(){
			return this.logistics_no_;
		}
		
		public void SetLogistics_no(string value){
			this.logistics_no_ = value;
		}
		public string GetTrade_id(){
			return this.trade_id_;
		}
		
		public void SetTrade_id(string value){
			this.trade_id_ = value;
		}
		public com.vip.vop.logistics.Linkman GetLinkman(){
			return this.linkman_;
		}
		
		public void SetLinkman(com.vip.vop.logistics.Linkman value){
			this.linkman_ = value;
		}
		public string GetAction(){
			return this.action_;
		}
		
		public void SetAction(string value){
			this.action_ = value;
		}
		public System.DateTime? GetOp_time(){
			return this.op_time_;
		}
		
		public void SetOp_time(System.DateTime? value){
			this.op_time_ = value;
		}
		public string GetReasonType(){
			return this.reasonType_;
		}
		
		public void SetReasonType(string value){
			this.reasonType_ = value;
		}
		public com.vip.vop.logistics.carrier.service.CollectionPacket GetPacket(){
			return this.packet_;
		}
		
		public void SetPacket(com.vip.vop.logistics.carrier.service.CollectionPacket value){
			this.packet_ = value;
		}
		
	}
	
}