using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.inventory.service.wop{
	
	
	
	
	
	public class WopInvChgLogReq {
		
		///<summary>
		/// 库存变动流水号,全局唯一保持幂等
		///</summary>
		
		private string seqNo_;
		
		///<summary>
		/// 渠道编码
		///</summary>
		
		private string companyCode_;
		
		///<summary>
		/// 库存变动指令标识:http://wiki.corp.vipshop.com/pages/viewpage.action?pageId=699637301
		///</summary>
		
		private int? bizReceiptType_;
		
		///<summary>
		/// 业务单据号,当时采购或调拨业务时,需要传
		///</summary>
		
		private string bizReceiptCode_;
		
		///<summary>
		/// 仓库编码
		///</summary>
		
		private string warehouseStoreCode_;
		
		///<summary>
		/// 中台商品条码
		///</summary>
		
		private string xlsBarcode_;
		
		///<summary>
		/// 采购单号
		///</summary>
		
		private string poNo_;
		
		///<summary>
		/// 库存类型:2-SI
		///</summary>
		
		private int? stockType_;
		
		///<summary>
		/// 货品等级:http://wiki.corp.vipshop.com/pages/viewpage.action?pageId=714182181
		///</summary>
		
		private int? goodsGrade_;
		
		///<summary>
		/// 是否可用(可售),1-可用,0-不可用
		///</summary>
		
		private int? sellingStatus_;
		
		///<summary>
		/// 变动数量
		///</summary>
		
		private int? quantity_;
		
		///<summary>
		/// 业务操作时间,13位毫秒
		///</summary>
		
		private long? bizTime_;
		
		public string GetSeqNo(){
			return this.seqNo_;
		}
		
		public void SetSeqNo(string value){
			this.seqNo_ = value;
		}
		public string GetCompanyCode(){
			return this.companyCode_;
		}
		
		public void SetCompanyCode(string value){
			this.companyCode_ = value;
		}
		public int? GetBizReceiptType(){
			return this.bizReceiptType_;
		}
		
		public void SetBizReceiptType(int? value){
			this.bizReceiptType_ = value;
		}
		public string GetBizReceiptCode(){
			return this.bizReceiptCode_;
		}
		
		public void SetBizReceiptCode(string value){
			this.bizReceiptCode_ = value;
		}
		public string GetWarehouseStoreCode(){
			return this.warehouseStoreCode_;
		}
		
		public void SetWarehouseStoreCode(string value){
			this.warehouseStoreCode_ = value;
		}
		public string GetXlsBarcode(){
			return this.xlsBarcode_;
		}
		
		public void SetXlsBarcode(string value){
			this.xlsBarcode_ = value;
		}
		public string GetPoNo(){
			return this.poNo_;
		}
		
		public void SetPoNo(string value){
			this.poNo_ = value;
		}
		public int? GetStockType(){
			return this.stockType_;
		}
		
		public void SetStockType(int? value){
			this.stockType_ = value;
		}
		public int? GetGoodsGrade(){
			return this.goodsGrade_;
		}
		
		public void SetGoodsGrade(int? value){
			this.goodsGrade_ = value;
		}
		public int? GetSellingStatus(){
			return this.sellingStatus_;
		}
		
		public void SetSellingStatus(int? value){
			this.sellingStatus_ = value;
		}
		public int? GetQuantity(){
			return this.quantity_;
		}
		
		public void SetQuantity(int? value){
			this.quantity_ = value;
		}
		public long? GetBizTime(){
			return this.bizTime_;
		}
		
		public void SetBizTime(long? value){
			this.bizTime_ = value;
		}
		
	}
	
}