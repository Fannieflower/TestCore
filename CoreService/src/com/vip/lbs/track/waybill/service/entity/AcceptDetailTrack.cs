using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.lbs.track.waybill.service.entity{
	
	
	
	
	
	public class AcceptDetailTrack {
		
		///<summary>
		/// 承运商编码
		///</summary>
		
		private string shipperCode_;
		
		///<summary>
		/// 承运商名称
		///</summary>
		
		private string shipperName_;
		
		///<summary>
		/// 承运商联系电话
		///</summary>
		
		private string shipperTel_;
		
		///<summary>
		/// 运单号
		///</summary>
		
		private string logisticNum_;
		
		///<summary>
		/// 订单号
		///</summary>
		
		private string orderSn_;
		
		///<summary>
		/// 明细返回信息
		///</summary>
		
		private List<com.vip.lbs.track.waybill.service.entity.DetailTracks> trackList_;
		
		public string GetShipperCode(){
			return this.shipperCode_;
		}
		
		public void SetShipperCode(string value){
			this.shipperCode_ = value;
		}
		public string GetShipperName(){
			return this.shipperName_;
		}
		
		public void SetShipperName(string value){
			this.shipperName_ = value;
		}
		public string GetShipperTel(){
			return this.shipperTel_;
		}
		
		public void SetShipperTel(string value){
			this.shipperTel_ = value;
		}
		public string GetLogisticNum(){
			return this.logisticNum_;
		}
		
		public void SetLogisticNum(string value){
			this.logisticNum_ = value;
		}
		public string GetOrderSn(){
			return this.orderSn_;
		}
		
		public void SetOrderSn(string value){
			this.orderSn_ = value;
		}
		public List<com.vip.lbs.track.waybill.service.entity.DetailTracks> GetTrackList(){
			return this.trackList_;
		}
		
		public void SetTrackList(List<com.vip.lbs.track.waybill.service.entity.DetailTracks> value){
			this.trackList_ = value;
		}
		
	}
	
}