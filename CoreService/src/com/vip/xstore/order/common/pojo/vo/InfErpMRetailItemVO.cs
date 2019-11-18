using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.order.common.pojo.vo{
	
	
	
	
	
	public class InfErpMRetailItemVO {
		
		///<summary>
		/// 主键id
		///</summary>
		
		private long? id_;
		
		///<summary>
		/// 主表ID
		///</summary>
		
		private long? mRetailId_;
		
		///<summary>
		/// 条码
		///</summary>
		
		private string mProductalias_;
		
		///<summary>
		/// 零售价,吊牌价
		///</summary>
		
		private string pricelist_;
		
		///<summary>
		/// 成交价,销售价,优惠后的价格，最终会员到手价格
		///</summary>
		
		private string priceactual_;
		
		///<summary>
		/// 折扣,销售价/吊牌价
		///</summary>
		
		private string discount_;
		
		///<summary>
		/// 数量,销售数量，退货时是负数
		///</summary>
		
		private int? qty_;
		
		///<summary>
		/// 营业员ID,导购员ID
		///</summary>
		
		private long? salesrepId_;
		
		///<summary>
		/// 营业员,导购员
		///</summary>
		
		private string salesrep_;
		
		///<summary>
		/// 原单编号
		///</summary>
		
		private string orgdocno_;
		
		///<summary>
		/// 退货原因ID
		///</summary>
		
		private long? webposRetreasonId_;
		
		///<summary>
		/// 退货原因
		///</summary>
		
		private string webposRetreason_;
		
		///<summary>
		/// 记录创建时间
		///</summary>
		
		private long? createTime_;
		
		///<summary>
		/// 记录更新时间
		///</summary>
		
		private long? updateTime_;
		
		///<summary>
		/// 是否逻辑删除，0 否，1 是
		///</summary>
		
		private int? isDeleted_;
		
		///<summary>
		/// 线上订单MP订单号
		///</summary>
		
		private string salesrepNo_;
		
		///<summary>
		/// 实际发货数量，退货时是负数
		///</summary>
		
		private int? realQty_;
		
		public long? GetId(){
			return this.id_;
		}
		
		public void SetId(long? value){
			this.id_ = value;
		}
		public long? GetMRetailId(){
			return this.mRetailId_;
		}
		
		public void SetMRetailId(long? value){
			this.mRetailId_ = value;
		}
		public string GetMProductalias(){
			return this.mProductalias_;
		}
		
		public void SetMProductalias(string value){
			this.mProductalias_ = value;
		}
		public string GetPricelist(){
			return this.pricelist_;
		}
		
		public void SetPricelist(string value){
			this.pricelist_ = value;
		}
		public string GetPriceactual(){
			return this.priceactual_;
		}
		
		public void SetPriceactual(string value){
			this.priceactual_ = value;
		}
		public string GetDiscount(){
			return this.discount_;
		}
		
		public void SetDiscount(string value){
			this.discount_ = value;
		}
		public int? GetQty(){
			return this.qty_;
		}
		
		public void SetQty(int? value){
			this.qty_ = value;
		}
		public long? GetSalesrepId(){
			return this.salesrepId_;
		}
		
		public void SetSalesrepId(long? value){
			this.salesrepId_ = value;
		}
		public string GetSalesrep(){
			return this.salesrep_;
		}
		
		public void SetSalesrep(string value){
			this.salesrep_ = value;
		}
		public string GetOrgdocno(){
			return this.orgdocno_;
		}
		
		public void SetOrgdocno(string value){
			this.orgdocno_ = value;
		}
		public long? GetWebposRetreasonId(){
			return this.webposRetreasonId_;
		}
		
		public void SetWebposRetreasonId(long? value){
			this.webposRetreasonId_ = value;
		}
		public string GetWebposRetreason(){
			return this.webposRetreason_;
		}
		
		public void SetWebposRetreason(string value){
			this.webposRetreason_ = value;
		}
		public long? GetCreateTime(){
			return this.createTime_;
		}
		
		public void SetCreateTime(long? value){
			this.createTime_ = value;
		}
		public long? GetUpdateTime(){
			return this.updateTime_;
		}
		
		public void SetUpdateTime(long? value){
			this.updateTime_ = value;
		}
		public int? GetIsDeleted(){
			return this.isDeleted_;
		}
		
		public void SetIsDeleted(int? value){
			this.isDeleted_ = value;
		}
		public string GetSalesrepNo(){
			return this.salesrepNo_;
		}
		
		public void SetSalesrepNo(string value){
			this.salesrepNo_ = value;
		}
		public int? GetRealQty(){
			return this.realQty_;
		}
		
		public void SetRealQty(int? value){
			this.realQty_ = value;
		}
		
	}
	
}