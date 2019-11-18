using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.logistics.carrier.service{
	
	
	
	
	
	public class LoadingListReq {
		
		///<summary>
		/// 批次号，全局唯一， 格式【车牌号（非电动车补X）（7位） + 年月日（6位）+ 按天自增序列（5位）】如：B12345X19090100001
		/// @sampleValue batch_no shunfeng00001
		///</summary>
		
		private string batch_no_;
		
		///<summary>
		/// 仓库编码（申报接口提供的仓库编码）
		/// @sampleValue warehouse VIP_NH
		///</summary>
		
		private string warehouse_;
		
		///<summary>
		/// 车牌号
		/// @sampleValue license_plate_no 津B12345
		///</summary>
		
		private string license_plate_no_;
		
		///<summary>
		/// 装载总包裹数量
		/// @sampleValue packet_quantity 20
		///</summary>
		
		private int? packet_quantity_;
		
		///<summary>
		/// 操作时间 （单位：毫秒）
		/// @sampleValue op_time 1566437975000
		///</summary>
		
		private long? op_time_;
		
		///<summary>
		/// 操作类型（1、新增 2、作废）
		/// @sampleValue op_type 1
		///</summary>
		
		private int? op_type_;
		
		///<summary>
		/// 分页上传页码，op_type为2时页码为0
		/// @sampleValue page 1
		///</summary>
		
		private int? page_;
		
		///<summary>
		/// 装载明细（最大限制300）
		/// @sampleValue loading_items 
		///</summary>
		
		private List<com.vip.vop.logistics.carrier.service.LoadingItem> loading_items_;
		
		public string GetBatch_no(){
			return this.batch_no_;
		}
		
		public void SetBatch_no(string value){
			this.batch_no_ = value;
		}
		public string GetWarehouse(){
			return this.warehouse_;
		}
		
		public void SetWarehouse(string value){
			this.warehouse_ = value;
		}
		public string GetLicense_plate_no(){
			return this.license_plate_no_;
		}
		
		public void SetLicense_plate_no(string value){
			this.license_plate_no_ = value;
		}
		public int? GetPacket_quantity(){
			return this.packet_quantity_;
		}
		
		public void SetPacket_quantity(int? value){
			this.packet_quantity_ = value;
		}
		public long? GetOp_time(){
			return this.op_time_;
		}
		
		public void SetOp_time(long? value){
			this.op_time_ = value;
		}
		public int? GetOp_type(){
			return this.op_type_;
		}
		
		public void SetOp_type(int? value){
			this.op_type_ = value;
		}
		public int? GetPage(){
			return this.page_;
		}
		
		public void SetPage(int? value){
			this.page_ = value;
		}
		public List<com.vip.vop.logistics.carrier.service.LoadingItem> GetLoading_items(){
			return this.loading_items_;
		}
		
		public void SetLoading_items(List<com.vip.vop.logistics.carrier.service.LoadingItem> value){
			this.loading_items_ = value;
		}
		
	}
	
}