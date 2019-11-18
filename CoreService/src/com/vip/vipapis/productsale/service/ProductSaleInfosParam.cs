using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vipapis.productsale.service{
	
	
	
	
	
	public class ProductSaleInfosParam {
		
		///<summary>
		/// 项目编码
		///</summary>
		
		private List<long?> globalIds_;
		
		///<summary>
		/// 序列号
		///</summary>
		
		private List<string> serialNos_;
		
		///<summary>
		/// 供应商编码
		///</summary>
		
		private List<string> vendorCodes_;
		
		///<summary>
		/// 商品名称
		///</summary>
		
		private List<string> itemDescs_;
		
		///<summary>
		/// 商品条码
		///</summary>
		
		private List<string> itemNos_;
		
		///<summary>
		/// 下单起始时间，单位毫秒
		///</summary>
		
		private long? startTime_;
		
		///<summary>
		/// 下单结束时间，单位毫秒
		///</summary>
		
		private long? endTime_;
		
		///<summary>
		/// 审批起始时间，单位毫秒
		///</summary>
		
		private long? auditStartTime_;
		
		///<summary>
		/// 审批结束时间，单位毫秒
		///</summary>
		
		private long? auditEndTime_;
		
		///<summary>
		/// 审批状态
		///</summary>
		
		private List<byte?> auditStatus_;
		
		///<summary>
		/// 页码
		/// @sampleValue page page=1
		///</summary>
		
		private int? page_;
		
		///<summary>
		/// 每页记录数
		/// @sampleValue limit limit=1000
		///</summary>
		
		private int? limit_;
		
		public List<long?> GetGlobalIds(){
			return this.globalIds_;
		}
		
		public void SetGlobalIds(List<long?> value){
			this.globalIds_ = value;
		}
		public List<string> GetSerialNos(){
			return this.serialNos_;
		}
		
		public void SetSerialNos(List<string> value){
			this.serialNos_ = value;
		}
		public List<string> GetVendorCodes(){
			return this.vendorCodes_;
		}
		
		public void SetVendorCodes(List<string> value){
			this.vendorCodes_ = value;
		}
		public List<string> GetItemDescs(){
			return this.itemDescs_;
		}
		
		public void SetItemDescs(List<string> value){
			this.itemDescs_ = value;
		}
		public List<string> GetItemNos(){
			return this.itemNos_;
		}
		
		public void SetItemNos(List<string> value){
			this.itemNos_ = value;
		}
		public long? GetStartTime(){
			return this.startTime_;
		}
		
		public void SetStartTime(long? value){
			this.startTime_ = value;
		}
		public long? GetEndTime(){
			return this.endTime_;
		}
		
		public void SetEndTime(long? value){
			this.endTime_ = value;
		}
		public long? GetAuditStartTime(){
			return this.auditStartTime_;
		}
		
		public void SetAuditStartTime(long? value){
			this.auditStartTime_ = value;
		}
		public long? GetAuditEndTime(){
			return this.auditEndTime_;
		}
		
		public void SetAuditEndTime(long? value){
			this.auditEndTime_ = value;
		}
		public List<byte?> GetAuditStatus(){
			return this.auditStatus_;
		}
		
		public void SetAuditStatus(List<byte?> value){
			this.auditStatus_ = value;
		}
		public int? GetPage(){
			return this.page_;
		}
		
		public void SetPage(int? value){
			this.page_ = value;
		}
		public int? GetLimit(){
			return this.limit_;
		}
		
		public void SetLimit(int? value){
			this.limit_ = value;
		}
		
	}
	
}