using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.tpc.api.model{
	
	
	
	
	
	public class LoadOrderRequest {
		
		///<summary>
		/// 装载批次ID，固定前缀+序列号，保证全局唯一
		///</summary>
		
		private string loadingId_;
		
		///<summary>
		/// 所属仓库编码，申报接口提供的仓库编码字段
		///</summary>
		
		private string warehouseCode_;
		
		///<summary>
		/// 承运商编码
		///</summary>
		
		private string shipperCode_;
		
		///<summary>
		/// 车牌号码，例如：津B49284
		///</summary>
		
		private string carLicense_;
		
		///<summary>
		/// 装载单总包裹数	
		///</summary>
		
		private int? loadingCount_;
		
		///<summary>
		/// 操作类型，枚举值：1 新增；2 作废
		///</summary>
		
		private int? operateType_;
		
		///<summary>
		/// 查询的页数（大于0的整数），可以做为批数，第X批，说明：【operateType】为【2】时，【pageIndex】为0
		///</summary>
		
		private int? pageIndex_;
		
		///<summary>
		/// 操作时间（单位：ms），业务发生时间
		///</summary>
		
		private long? operateTime_;
		
		///<summary>
		/// 批量单据明细对象，批量限制数300
		///</summary>
		
		private List<com.vip.tpc.api.model.LoadDetail> loadDetailSet_;
		
		public string GetLoadingId(){
			return this.loadingId_;
		}
		
		public void SetLoadingId(string value){
			this.loadingId_ = value;
		}
		public string GetWarehouseCode(){
			return this.warehouseCode_;
		}
		
		public void SetWarehouseCode(string value){
			this.warehouseCode_ = value;
		}
		public string GetShipperCode(){
			return this.shipperCode_;
		}
		
		public void SetShipperCode(string value){
			this.shipperCode_ = value;
		}
		public string GetCarLicense(){
			return this.carLicense_;
		}
		
		public void SetCarLicense(string value){
			this.carLicense_ = value;
		}
		public int? GetLoadingCount(){
			return this.loadingCount_;
		}
		
		public void SetLoadingCount(int? value){
			this.loadingCount_ = value;
		}
		public int? GetOperateType(){
			return this.operateType_;
		}
		
		public void SetOperateType(int? value){
			this.operateType_ = value;
		}
		public int? GetPageIndex(){
			return this.pageIndex_;
		}
		
		public void SetPageIndex(int? value){
			this.pageIndex_ = value;
		}
		public long? GetOperateTime(){
			return this.operateTime_;
		}
		
		public void SetOperateTime(long? value){
			this.operateTime_ = value;
		}
		public List<com.vip.tpc.api.model.LoadDetail> GetLoadDetailSet(){
			return this.loadDetailSet_;
		}
		
		public void SetLoadDetailSet(List<com.vip.tpc.api.model.LoadDetail> value){
			this.loadDetailSet_ = value;
		}
		
	}
	
}