using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.bill{
	
	
	
	
	
	public class BillDetailInfo {
		
		///<summary>
		/// 在同一个渠道商中必须全局唯一的事务请求ID
		///</summary>
		
		private long? channel_data_id_;
		
		///<summary>
		/// 订单编号，第三方订单编号
		///</summary>
		
		private string order_sn_;
		
		///<summary>
		/// 单据编号，非销售单的第三方单据编号
		///</summary>
		
		private string receipt_no_;
		
		///<summary>
		/// 销售订单/售后申请单/取消退款单/非销售单
		///</summary>
		
		private string receipt_type_;
		
		///<summary>
		/// 第三方商品ID=唯品会商品ID(prodSkuId)
		///</summary>
		
		private long? prod_sku_id_;
		
		///<summary>
		/// 第三方商品编号
		///</summary>
		
		private string ext_goods_no_;
		
		///<summary>
		/// 第三方商品描述
		///</summary>
		
		private string ext_goods_name_;
		
		///<summary>
		/// VIP采购档期Id
		///</summary>
		
		private long? schedule_id_;
		
		///<summary>
		/// 第三方商品品类
		///</summary>
		
		private string category_;
		
		///<summary>
		/// 第三方商品税率
		///</summary>
		
		private string tax_rate_;
		
		///<summary>
		/// 佣金模式下的佣金比例，如0.1,0.15等
		///</summary>
		
		private string commission_ratio_;
		
		///<summary>
		/// 已结算：账户已收款；未结算：符合结算条件，但资金未实际划拨
		///</summary>
		
		private string settlement_status_;
		
		///<summary>
		/// 单据创建时间(毫秒为单位的数字型时间)
		///</summary>
		
		private long? cost_occurrence_time_;
		
		///<summary>
		/// 确认收货时间or退款时间(毫秒为单位的数字型时间)
		///</summary>
		
		private long? cost_chargeable_time_;
		
		///<summary>
		/// 资金结算时间(毫秒为单位的数字型时间)
		///</summary>
		
		private long? cost_settlement_time_;
		
		///<summary>
		/// 费用项，货款/佣金/运费/赔付费
		///</summary>
		
		private string cost_item_;
		
		///<summary>
		/// 金额(2位小数)
		///</summary>
		
		private string amount_;
		
		///<summary>
		/// 币种
		///</summary>
		
		private string currency_;
		
		///<summary>
		/// 对于商家（VIP）来说，收入/支出
		///</summary>
		
		private string income_expenses_direction_;
		
		///<summary>
		/// 现金流水号d
		///</summary>
		
		private string money_serialNo_;
		
		public long? GetChannel_data_id(){
			return this.channel_data_id_;
		}
		
		public void SetChannel_data_id(long? value){
			this.channel_data_id_ = value;
		}
		public string GetOrder_sn(){
			return this.order_sn_;
		}
		
		public void SetOrder_sn(string value){
			this.order_sn_ = value;
		}
		public string GetReceipt_no(){
			return this.receipt_no_;
		}
		
		public void SetReceipt_no(string value){
			this.receipt_no_ = value;
		}
		public string GetReceipt_type(){
			return this.receipt_type_;
		}
		
		public void SetReceipt_type(string value){
			this.receipt_type_ = value;
		}
		public long? GetProd_sku_id(){
			return this.prod_sku_id_;
		}
		
		public void SetProd_sku_id(long? value){
			this.prod_sku_id_ = value;
		}
		public string GetExt_goods_no(){
			return this.ext_goods_no_;
		}
		
		public void SetExt_goods_no(string value){
			this.ext_goods_no_ = value;
		}
		public string GetExt_goods_name(){
			return this.ext_goods_name_;
		}
		
		public void SetExt_goods_name(string value){
			this.ext_goods_name_ = value;
		}
		public long? GetSchedule_id(){
			return this.schedule_id_;
		}
		
		public void SetSchedule_id(long? value){
			this.schedule_id_ = value;
		}
		public string GetCategory(){
			return this.category_;
		}
		
		public void SetCategory(string value){
			this.category_ = value;
		}
		public string GetTax_rate(){
			return this.tax_rate_;
		}
		
		public void SetTax_rate(string value){
			this.tax_rate_ = value;
		}
		public string GetCommission_ratio(){
			return this.commission_ratio_;
		}
		
		public void SetCommission_ratio(string value){
			this.commission_ratio_ = value;
		}
		public string GetSettlement_status(){
			return this.settlement_status_;
		}
		
		public void SetSettlement_status(string value){
			this.settlement_status_ = value;
		}
		public long? GetCost_occurrence_time(){
			return this.cost_occurrence_time_;
		}
		
		public void SetCost_occurrence_time(long? value){
			this.cost_occurrence_time_ = value;
		}
		public long? GetCost_chargeable_time(){
			return this.cost_chargeable_time_;
		}
		
		public void SetCost_chargeable_time(long? value){
			this.cost_chargeable_time_ = value;
		}
		public long? GetCost_settlement_time(){
			return this.cost_settlement_time_;
		}
		
		public void SetCost_settlement_time(long? value){
			this.cost_settlement_time_ = value;
		}
		public string GetCost_item(){
			return this.cost_item_;
		}
		
		public void SetCost_item(string value){
			this.cost_item_ = value;
		}
		public string GetAmount(){
			return this.amount_;
		}
		
		public void SetAmount(string value){
			this.amount_ = value;
		}
		public string GetCurrency(){
			return this.currency_;
		}
		
		public void SetCurrency(string value){
			this.currency_ = value;
		}
		public string GetIncome_expenses_direction(){
			return this.income_expenses_direction_;
		}
		
		public void SetIncome_expenses_direction(string value){
			this.income_expenses_direction_ = value;
		}
		public string GetMoney_serialNo(){
			return this.money_serialNo_;
		}
		
		public void SetMoney_serialNo(string value){
			this.money_serialNo_ = value;
		}
		
	}
	
}