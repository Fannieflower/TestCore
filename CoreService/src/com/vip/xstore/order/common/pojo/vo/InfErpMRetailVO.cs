using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.order.common.pojo.vo{
	
	
	
	
	
	public class InfErpMRetailVO {
		
		///<summary>
		/// 主键id
		///</summary>
		
		private long? id_;
		
		///<summary>
		/// 单据编号,ERP系统中的零售单号
		///</summary>
		
		private string docno_;
		
		///<summary>
		/// 云仓原单号,对应的是商城订单号
		///</summary>
		
		private string splitDocno_;
		
		///<summary>
		/// 单据日期,零售单号创建日期，只是日期
		///</summary>
		
		private int? billdate_;
		
		///<summary>
		/// POS零售单号
		///</summary>
		
		private string refno_;
		
		///<summary>
		/// 会员
		///</summary>
		
		private string openid_;
		
		///<summary>
		/// RFID单号
		///</summary>
		
		private string rfidDocno_;
		
		///<summary>
		/// 零售单类型
		///</summary>
		
		private string retailbilltype_;
		
		///<summary>
		/// 店仓ID
		///</summary>
		
		private long? cStoreId_;
		
		///<summary>
		/// 店仓
		///</summary>
		
		private string cStore_;
		
		///<summary>
		/// 类别
		///</summary>
		
		private string uploadtype_;
		
		///<summary>
		/// 零售员ID
		///</summary>
		
		private long? salesrepId_;
		
		///<summary>
		/// 零售员
		///</summary>
		
		private string salesrep_;
		
		///<summary>
		/// 机号
		///</summary>
		
		private string planNum_;
		
		///<summary>
		/// 备注
		///</summary>
		
		private string description_;
		
		///<summary>
		/// 总行数
		///</summary>
		
		private int? totLines_;
		
		///<summary>
		/// 总数量,订单中所有商品的数量总和
		///</summary>
		
		private int? totQty_;
		
		///<summary>
		/// 总零售金额,商品行中零售金额总和
		///</summary>
		
		private string totAmtList_;
		
		///<summary>
		/// 总成交金额,商品行中成交金额中和
		///</summary>
		
		private string totAmtActual_;
		
		///<summary>
		/// 平均折扣,总成交金额/总零售金额
		///</summary>
		
		private string avgDiscount_;
		
		///<summary>
		/// 云仓订单号,是ERP中的云仓订单号
		///</summary>
		
		private string o2oSo_;
		
		///<summary>
		/// 创建人ID
		///</summary>
		
		private long? ownerid_;
		
		///<summary>
		/// 创建人
		///</summary>
		
		private string owner_;
		
		///<summary>
		/// 创建时间
		///</summary>
		
		private int? creationdate_;
		
		///<summary>
		/// 修改人ID
		///</summary>
		
		private long? modifierid_;
		
		///<summary>
		/// 修改人
		///</summary>
		
		private string modifier_;
		
		///<summary>
		/// 修改时间
		///</summary>
		
		private int? modifieddate_;
		
		///<summary>
		/// 提交人ID
		///</summary>
		
		private long? statuserid_;
		
		///<summary>
		/// 提交人
		///</summary>
		
		private string statuser_;
		
		///<summary>
		/// 提交时间,使用这个时间作为单据确认时间，新零售订单的创建时间
		///</summary>
		
		private int? statustime_;
		
		///<summary>
		/// 原退货单号
		///</summary>
		
		private string orgdocno_;
		
		///<summary>
		/// 公司编码(xstorebuy/maxxbuy)
		///</summary>
		
		private string companyCode_;
		
		///<summary>
		/// 处理时间
		///</summary>
		
		private long? procTime_;
		
		///<summary>
		/// 处理状态：-1 处理失败，0 未处理，1 处理中，2 已处理
		///</summary>
		
		private int? procStatus_;
		
		///<summary>
		/// 错误次数
		///</summary>
		
		private int? errorCount_;
		
		///<summary>
		/// 错误信息
		///</summary>
		
		private string errorMsg_;
		
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
		/// 客退单关联的原正向零售单号
		///</summary>
		
		private string relatedDocno_;
		
		///<summary>
		/// 线上订单MP客退单号
		///</summary>
		
		private string storeAfterSaleSn_;
		
		///<summary>
		/// 零售员编号
		///</summary>
		
		private string salesrepNo_;
		
		public long? GetId(){
			return this.id_;
		}
		
		public void SetId(long? value){
			this.id_ = value;
		}
		public string GetDocno(){
			return this.docno_;
		}
		
		public void SetDocno(string value){
			this.docno_ = value;
		}
		public string GetSplitDocno(){
			return this.splitDocno_;
		}
		
		public void SetSplitDocno(string value){
			this.splitDocno_ = value;
		}
		public int? GetBilldate(){
			return this.billdate_;
		}
		
		public void SetBilldate(int? value){
			this.billdate_ = value;
		}
		public string GetRefno(){
			return this.refno_;
		}
		
		public void SetRefno(string value){
			this.refno_ = value;
		}
		public string GetOpenid(){
			return this.openid_;
		}
		
		public void SetOpenid(string value){
			this.openid_ = value;
		}
		public string GetRfidDocno(){
			return this.rfidDocno_;
		}
		
		public void SetRfidDocno(string value){
			this.rfidDocno_ = value;
		}
		public string GetRetailbilltype(){
			return this.retailbilltype_;
		}
		
		public void SetRetailbilltype(string value){
			this.retailbilltype_ = value;
		}
		public long? GetCStoreId(){
			return this.cStoreId_;
		}
		
		public void SetCStoreId(long? value){
			this.cStoreId_ = value;
		}
		public string GetCStore(){
			return this.cStore_;
		}
		
		public void SetCStore(string value){
			this.cStore_ = value;
		}
		public string GetUploadtype(){
			return this.uploadtype_;
		}
		
		public void SetUploadtype(string value){
			this.uploadtype_ = value;
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
		public string GetPlanNum(){
			return this.planNum_;
		}
		
		public void SetPlanNum(string value){
			this.planNum_ = value;
		}
		public string GetDescription(){
			return this.description_;
		}
		
		public void SetDescription(string value){
			this.description_ = value;
		}
		public int? GetTotLines(){
			return this.totLines_;
		}
		
		public void SetTotLines(int? value){
			this.totLines_ = value;
		}
		public int? GetTotQty(){
			return this.totQty_;
		}
		
		public void SetTotQty(int? value){
			this.totQty_ = value;
		}
		public string GetTotAmtList(){
			return this.totAmtList_;
		}
		
		public void SetTotAmtList(string value){
			this.totAmtList_ = value;
		}
		public string GetTotAmtActual(){
			return this.totAmtActual_;
		}
		
		public void SetTotAmtActual(string value){
			this.totAmtActual_ = value;
		}
		public string GetAvgDiscount(){
			return this.avgDiscount_;
		}
		
		public void SetAvgDiscount(string value){
			this.avgDiscount_ = value;
		}
		public string GetO2oSo(){
			return this.o2oSo_;
		}
		
		public void SetO2oSo(string value){
			this.o2oSo_ = value;
		}
		public long? GetOwnerid(){
			return this.ownerid_;
		}
		
		public void SetOwnerid(long? value){
			this.ownerid_ = value;
		}
		public string GetOwner(){
			return this.owner_;
		}
		
		public void SetOwner(string value){
			this.owner_ = value;
		}
		public int? GetCreationdate(){
			return this.creationdate_;
		}
		
		public void SetCreationdate(int? value){
			this.creationdate_ = value;
		}
		public long? GetModifierid(){
			return this.modifierid_;
		}
		
		public void SetModifierid(long? value){
			this.modifierid_ = value;
		}
		public string GetModifier(){
			return this.modifier_;
		}
		
		public void SetModifier(string value){
			this.modifier_ = value;
		}
		public int? GetModifieddate(){
			return this.modifieddate_;
		}
		
		public void SetModifieddate(int? value){
			this.modifieddate_ = value;
		}
		public long? GetStatuserid(){
			return this.statuserid_;
		}
		
		public void SetStatuserid(long? value){
			this.statuserid_ = value;
		}
		public string GetStatuser(){
			return this.statuser_;
		}
		
		public void SetStatuser(string value){
			this.statuser_ = value;
		}
		public int? GetStatustime(){
			return this.statustime_;
		}
		
		public void SetStatustime(int? value){
			this.statustime_ = value;
		}
		public string GetOrgdocno(){
			return this.orgdocno_;
		}
		
		public void SetOrgdocno(string value){
			this.orgdocno_ = value;
		}
		public string GetCompanyCode(){
			return this.companyCode_;
		}
		
		public void SetCompanyCode(string value){
			this.companyCode_ = value;
		}
		public long? GetProcTime(){
			return this.procTime_;
		}
		
		public void SetProcTime(long? value){
			this.procTime_ = value;
		}
		public int? GetProcStatus(){
			return this.procStatus_;
		}
		
		public void SetProcStatus(int? value){
			this.procStatus_ = value;
		}
		public int? GetErrorCount(){
			return this.errorCount_;
		}
		
		public void SetErrorCount(int? value){
			this.errorCount_ = value;
		}
		public string GetErrorMsg(){
			return this.errorMsg_;
		}
		
		public void SetErrorMsg(string value){
			this.errorMsg_ = value;
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
		public string GetRelatedDocno(){
			return this.relatedDocno_;
		}
		
		public void SetRelatedDocno(string value){
			this.relatedDocno_ = value;
		}
		public string GetStoreAfterSaleSn(){
			return this.storeAfterSaleSn_;
		}
		
		public void SetStoreAfterSaleSn(string value){
			this.storeAfterSaleSn_ = value;
		}
		public string GetSalesrepNo(){
			return this.salesrepNo_;
		}
		
		public void SetSalesrepNo(string value){
			this.salesrepNo_ = value;
		}
		
	}
	
}