using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.cc.bulkbuying.service{
	
	
	
	
	
	public class PurchaseOrderUpdateRequest {
		
		///<summary>
		/// 采购单号
		///</summary>
		
		private string purchaseNo_;
		
		///<summary>
		/// 上传文件路径或URL
		///</summary>
		
		private string uploadedFilePath_;
		
		///<summary>
		/// 买手组编码
		///</summary>
		
		private string buyerGroupCode_;
		
		///<summary>
		/// 买手组名称
		///</summary>
		
		private string buyerGroupName_;
		
		///<summary>
		/// 备注
		///</summary>
		
		private string remark_;
		
		///<summary>
		/// 货品类型：0、现货 1、囤货
		///</summary>
		
		private byte? goodsType_;
		
		///<summary>
		/// 可配货时间
		///</summary>
		
		private System.DateTime? distributableGoodsTime_;
		
		///<summary>
		/// 预计到货时间
		///</summary>
		
		private System.DateTime? estimateArrivalTime_;
		
		///<summary>
		/// 采购标签
		///</summary>
		
		private string purchaseLabel_;
		
		///<summary>
		/// 收货类型：0、大仓收货 1、门店收货 2、大仓分货
		///</summary>
		
		private byte? skipFlag_;
		
		///<summary>
		/// 结算模式：1、供货价 2、扣点
		///</summary>
		
		private byte? settlementMode_;
		
		///<summary>
		/// 扣点
		///</summary>
		
		private double? deduction_;
		
		public string GetPurchaseNo(){
			return this.purchaseNo_;
		}
		
		public void SetPurchaseNo(string value){
			this.purchaseNo_ = value;
		}
		public string GetUploadedFilePath(){
			return this.uploadedFilePath_;
		}
		
		public void SetUploadedFilePath(string value){
			this.uploadedFilePath_ = value;
		}
		public string GetBuyerGroupCode(){
			return this.buyerGroupCode_;
		}
		
		public void SetBuyerGroupCode(string value){
			this.buyerGroupCode_ = value;
		}
		public string GetBuyerGroupName(){
			return this.buyerGroupName_;
		}
		
		public void SetBuyerGroupName(string value){
			this.buyerGroupName_ = value;
		}
		public string GetRemark(){
			return this.remark_;
		}
		
		public void SetRemark(string value){
			this.remark_ = value;
		}
		public byte? GetGoodsType(){
			return this.goodsType_;
		}
		
		public void SetGoodsType(byte? value){
			this.goodsType_ = value;
		}
		public System.DateTime? GetDistributableGoodsTime(){
			return this.distributableGoodsTime_;
		}
		
		public void SetDistributableGoodsTime(System.DateTime? value){
			this.distributableGoodsTime_ = value;
		}
		public System.DateTime? GetEstimateArrivalTime(){
			return this.estimateArrivalTime_;
		}
		
		public void SetEstimateArrivalTime(System.DateTime? value){
			this.estimateArrivalTime_ = value;
		}
		public string GetPurchaseLabel(){
			return this.purchaseLabel_;
		}
		
		public void SetPurchaseLabel(string value){
			this.purchaseLabel_ = value;
		}
		public byte? GetSkipFlag(){
			return this.skipFlag_;
		}
		
		public void SetSkipFlag(byte? value){
			this.skipFlag_ = value;
		}
		public byte? GetSettlementMode(){
			return this.settlementMode_;
		}
		
		public void SetSettlementMode(byte? value){
			this.settlementMode_ = value;
		}
		public double? GetDeduction(){
			return this.deduction_;
		}
		
		public void SetDeduction(double? value){
			this.deduction_ = value;
		}
		
	}
	
}