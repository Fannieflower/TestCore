using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace vipapis.tpc.service{
	
	
	public class TpcExternalServiceHelper {
		
		
		
		public class acceptCarLoadDetail_args {
			
			///<summary>
			/// 承运商装车清单接口请求
			///</summary>
			
			private com.vip.tpc.api.model.AcceptCarLoadDetailRequest acceptCarLoadDetailRequest_;
			
			public com.vip.tpc.api.model.AcceptCarLoadDetailRequest GetAcceptCarLoadDetailRequest(){
				return this.acceptCarLoadDetailRequest_;
			}
			
			public void SetAcceptCarLoadDetailRequest(com.vip.tpc.api.model.AcceptCarLoadDetailRequest value){
				this.acceptCarLoadDetailRequest_ = value;
			}
			
		}
		
		
		
		
		public class anormalExpress_args {
			
			///<summary>
			/// 问题件信息上报请求
			///</summary>
			
			private com.vip.tpc.api.model.AnormalExpressRequest anormalExpressRequest_;
			
			public com.vip.tpc.api.model.AnormalExpressRequest GetAnormalExpressRequest(){
				return this.anormalExpressRequest_;
			}
			
			public void SetAnormalExpressRequest(com.vip.tpc.api.model.AnormalExpressRequest value){
				this.anormalExpressRequest_ = value;
			}
			
		}
		
		
		
		
		public class carrierTakingAway_args {
			
			///<summary>
			/// 承运商订单包裹揽收
			///</summary>
			
			private com.vip.tpc.api.model.CarrierTakingAwayRequest carrierTakingAwayRequest_;
			
			public com.vip.tpc.api.model.CarrierTakingAwayRequest GetCarrierTakingAwayRequest(){
				return this.carrierTakingAwayRequest_;
			}
			
			public void SetCarrierTakingAwayRequest(com.vip.tpc.api.model.CarrierTakingAwayRequest value){
				this.carrierTakingAwayRequest_ = value;
			}
			
		}
		
		
		
		
		public class carrierTakingAwayGoods_args {
			
			///<summary>
			/// 承运商上门揽件
			///</summary>
			
			private com.vip.tpc.api.model.CarrierTakingAwayGoodsRequest carrierTakingAwayGoodsRequest_;
			
			public com.vip.tpc.api.model.CarrierTakingAwayGoodsRequest GetCarrierTakingAwayGoodsRequest(){
				return this.carrierTakingAwayGoodsRequest_;
			}
			
			public void SetCarrierTakingAwayGoodsRequest(com.vip.tpc.api.model.CarrierTakingAwayGoodsRequest value){
				this.carrierTakingAwayGoodsRequest_ = value;
			}
			
		}
		
		
		
		
		public class getReturnAddress_args {
			
			///<summary>
			/// 获取退回地址请求
			///</summary>
			
			private com.vip.tpc.api.model.GetReturnAddressRequest getReturnAddressRequest_;
			
			public com.vip.tpc.api.model.GetReturnAddressRequest GetGetReturnAddressRequest(){
				return this.getReturnAddressRequest_;
			}
			
			public void SetGetReturnAddressRequest(com.vip.tpc.api.model.GetReturnAddressRequest value){
				this.getReturnAddressRequest_ = value;
			}
			
		}
		
		
		
		
		public class getSerialNumberRelation_args {
			
			///<summary>
			/// 获取单据编码关系请求
			///</summary>
			
			private com.vip.tpc.api.model.GetSerialNumberRelationRequest getSerialNumberRelationRequest_;
			
			public com.vip.tpc.api.model.GetSerialNumberRelationRequest GetGetSerialNumberRelationRequest(){
				return this.getSerialNumberRelationRequest_;
			}
			
			public void SetGetSerialNumberRelationRequest(com.vip.tpc.api.model.GetSerialNumberRelationRequest value){
				this.getSerialNumberRelationRequest_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class interceptReport_args {
			
			///<summary>
			/// 承运商运单拦截结果信息上报接口请求
			///</summary>
			
			private com.vip.tpc.api.model.InterceptReportRequest interceptReportRequest_;
			
			public com.vip.tpc.api.model.InterceptReportRequest GetInterceptReportRequest(){
				return this.interceptReportRequest_;
			}
			
			public void SetInterceptReportRequest(com.vip.tpc.api.model.InterceptReportRequest value){
				this.interceptReportRequest_ = value;
			}
			
		}
		
		
		
		
		public class packPhysicsAttribute_args {
			
			///<summary>
			/// 推送量方信息请求
			///</summary>
			
			private com.vip.tpc.api.model.PackPhysicsAttributeRequest packPhysicsAttributeRequest_;
			
			public com.vip.tpc.api.model.PackPhysicsAttributeRequest GetPackPhysicsAttributeRequest(){
				return this.packPhysicsAttributeRequest_;
			}
			
			public void SetPackPhysicsAttributeRequest(com.vip.tpc.api.model.PackPhysicsAttributeRequest value){
				this.packPhysicsAttributeRequest_ = value;
			}
			
		}
		
		
		
		
		public class acceptCarLoadDetail_result {
			
			///<summary>
			///</summary>
			
			private com.vip.tpc.api.model.AcceptCarLoadDetailResponse success_;
			
			public com.vip.tpc.api.model.AcceptCarLoadDetailResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.tpc.api.model.AcceptCarLoadDetailResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class anormalExpress_result {
			
			///<summary>
			///</summary>
			
			private com.vip.tpc.api.model.AnormalExpressResponse success_;
			
			public com.vip.tpc.api.model.AnormalExpressResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.tpc.api.model.AnormalExpressResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class carrierTakingAway_result {
			
			///<summary>
			///</summary>
			
			private com.vip.tpc.api.model.CarrierTakingAwayResponse success_;
			
			public com.vip.tpc.api.model.CarrierTakingAwayResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.tpc.api.model.CarrierTakingAwayResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class carrierTakingAwayGoods_result {
			
			///<summary>
			///</summary>
			
			private com.vip.tpc.api.model.CarrierTakingAwayGoodsResponse success_;
			
			public com.vip.tpc.api.model.CarrierTakingAwayGoodsResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.tpc.api.model.CarrierTakingAwayGoodsResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getReturnAddress_result {
			
			///<summary>
			///</summary>
			
			private com.vip.tpc.api.model.GetReturnAddressResponse success_;
			
			public com.vip.tpc.api.model.GetReturnAddressResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.tpc.api.model.GetReturnAddressResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getSerialNumberRelation_result {
			
			///<summary>
			///</summary>
			
			private com.vip.tpc.api.model.GetSerialNumberRelationResponse success_;
			
			public com.vip.tpc.api.model.GetSerialNumberRelationResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.tpc.api.model.GetSerialNumberRelationResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_result {
			
			///<summary>
			///</summary>
			
			private com.vip.hermes.core.health.CheckResult success_;
			
			public com.vip.hermes.core.health.CheckResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.hermes.core.health.CheckResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class interceptReport_result {
			
			///<summary>
			///</summary>
			
			private com.vip.tpc.api.model.InterceptReportResponse success_;
			
			public com.vip.tpc.api.model.InterceptReportResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.tpc.api.model.InterceptReportResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class packPhysicsAttribute_result {
			
			///<summary>
			///</summary>
			
			private com.vip.tpc.api.model.PackPhysicsAttributeResponse success_;
			
			public com.vip.tpc.api.model.PackPhysicsAttributeResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.tpc.api.model.PackPhysicsAttributeResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		
		public class acceptCarLoadDetail_argsHelper : TBeanSerializer<acceptCarLoadDetail_args>
		{
			
			public static acceptCarLoadDetail_argsHelper OBJ = new acceptCarLoadDetail_argsHelper();
			
			public static acceptCarLoadDetail_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(acceptCarLoadDetail_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.tpc.api.model.AcceptCarLoadDetailRequest value;
					
					value = new com.vip.tpc.api.model.AcceptCarLoadDetailRequest();
					com.vip.tpc.api.model.AcceptCarLoadDetailRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetAcceptCarLoadDetailRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(acceptCarLoadDetail_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetAcceptCarLoadDetailRequest() != null) {
					
					oprot.WriteFieldBegin("acceptCarLoadDetailRequest");
					
					com.vip.tpc.api.model.AcceptCarLoadDetailRequestHelper.getInstance().Write(structs.GetAcceptCarLoadDetailRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(acceptCarLoadDetail_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class anormalExpress_argsHelper : TBeanSerializer<anormalExpress_args>
		{
			
			public static anormalExpress_argsHelper OBJ = new anormalExpress_argsHelper();
			
			public static anormalExpress_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(anormalExpress_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.tpc.api.model.AnormalExpressRequest value;
					
					value = new com.vip.tpc.api.model.AnormalExpressRequest();
					com.vip.tpc.api.model.AnormalExpressRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetAnormalExpressRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(anormalExpress_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetAnormalExpressRequest() != null) {
					
					oprot.WriteFieldBegin("anormalExpressRequest");
					
					com.vip.tpc.api.model.AnormalExpressRequestHelper.getInstance().Write(structs.GetAnormalExpressRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(anormalExpress_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class carrierTakingAway_argsHelper : TBeanSerializer<carrierTakingAway_args>
		{
			
			public static carrierTakingAway_argsHelper OBJ = new carrierTakingAway_argsHelper();
			
			public static carrierTakingAway_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(carrierTakingAway_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.tpc.api.model.CarrierTakingAwayRequest value;
					
					value = new com.vip.tpc.api.model.CarrierTakingAwayRequest();
					com.vip.tpc.api.model.CarrierTakingAwayRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetCarrierTakingAwayRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(carrierTakingAway_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetCarrierTakingAwayRequest() != null) {
					
					oprot.WriteFieldBegin("carrierTakingAwayRequest");
					
					com.vip.tpc.api.model.CarrierTakingAwayRequestHelper.getInstance().Write(structs.GetCarrierTakingAwayRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(carrierTakingAway_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class carrierTakingAwayGoods_argsHelper : TBeanSerializer<carrierTakingAwayGoods_args>
		{
			
			public static carrierTakingAwayGoods_argsHelper OBJ = new carrierTakingAwayGoods_argsHelper();
			
			public static carrierTakingAwayGoods_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(carrierTakingAwayGoods_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.tpc.api.model.CarrierTakingAwayGoodsRequest value;
					
					value = new com.vip.tpc.api.model.CarrierTakingAwayGoodsRequest();
					com.vip.tpc.api.model.CarrierTakingAwayGoodsRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetCarrierTakingAwayGoodsRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(carrierTakingAwayGoods_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetCarrierTakingAwayGoodsRequest() != null) {
					
					oprot.WriteFieldBegin("carrierTakingAwayGoodsRequest");
					
					com.vip.tpc.api.model.CarrierTakingAwayGoodsRequestHelper.getInstance().Write(structs.GetCarrierTakingAwayGoodsRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(carrierTakingAwayGoods_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getReturnAddress_argsHelper : TBeanSerializer<getReturnAddress_args>
		{
			
			public static getReturnAddress_argsHelper OBJ = new getReturnAddress_argsHelper();
			
			public static getReturnAddress_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getReturnAddress_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.tpc.api.model.GetReturnAddressRequest value;
					
					value = new com.vip.tpc.api.model.GetReturnAddressRequest();
					com.vip.tpc.api.model.GetReturnAddressRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetGetReturnAddressRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getReturnAddress_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetGetReturnAddressRequest() != null) {
					
					oprot.WriteFieldBegin("getReturnAddressRequest");
					
					com.vip.tpc.api.model.GetReturnAddressRequestHelper.getInstance().Write(structs.GetGetReturnAddressRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getReturnAddress_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getSerialNumberRelation_argsHelper : TBeanSerializer<getSerialNumberRelation_args>
		{
			
			public static getSerialNumberRelation_argsHelper OBJ = new getSerialNumberRelation_argsHelper();
			
			public static getSerialNumberRelation_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getSerialNumberRelation_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.tpc.api.model.GetSerialNumberRelationRequest value;
					
					value = new com.vip.tpc.api.model.GetSerialNumberRelationRequest();
					com.vip.tpc.api.model.GetSerialNumberRelationRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetGetSerialNumberRelationRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getSerialNumberRelation_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetGetSerialNumberRelationRequest() != null) {
					
					oprot.WriteFieldBegin("getSerialNumberRelationRequest");
					
					com.vip.tpc.api.model.GetSerialNumberRelationRequestHelper.getInstance().Write(structs.GetGetSerialNumberRelationRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getSerialNumberRelation_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class healthCheck_argsHelper : TBeanSerializer<healthCheck_args>
		{
			
			public static healthCheck_argsHelper OBJ = new healthCheck_argsHelper();
			
			public static healthCheck_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(healthCheck_args structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(healthCheck_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(healthCheck_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class interceptReport_argsHelper : TBeanSerializer<interceptReport_args>
		{
			
			public static interceptReport_argsHelper OBJ = new interceptReport_argsHelper();
			
			public static interceptReport_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(interceptReport_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.tpc.api.model.InterceptReportRequest value;
					
					value = new com.vip.tpc.api.model.InterceptReportRequest();
					com.vip.tpc.api.model.InterceptReportRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetInterceptReportRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(interceptReport_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetInterceptReportRequest() != null) {
					
					oprot.WriteFieldBegin("interceptReportRequest");
					
					com.vip.tpc.api.model.InterceptReportRequestHelper.getInstance().Write(structs.GetInterceptReportRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(interceptReport_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class packPhysicsAttribute_argsHelper : TBeanSerializer<packPhysicsAttribute_args>
		{
			
			public static packPhysicsAttribute_argsHelper OBJ = new packPhysicsAttribute_argsHelper();
			
			public static packPhysicsAttribute_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(packPhysicsAttribute_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.tpc.api.model.PackPhysicsAttributeRequest value;
					
					value = new com.vip.tpc.api.model.PackPhysicsAttributeRequest();
					com.vip.tpc.api.model.PackPhysicsAttributeRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetPackPhysicsAttributeRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(packPhysicsAttribute_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPackPhysicsAttributeRequest() != null) {
					
					oprot.WriteFieldBegin("packPhysicsAttributeRequest");
					
					com.vip.tpc.api.model.PackPhysicsAttributeRequestHelper.getInstance().Write(structs.GetPackPhysicsAttributeRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(packPhysicsAttribute_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class acceptCarLoadDetail_resultHelper : TBeanSerializer<acceptCarLoadDetail_result>
		{
			
			public static acceptCarLoadDetail_resultHelper OBJ = new acceptCarLoadDetail_resultHelper();
			
			public static acceptCarLoadDetail_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(acceptCarLoadDetail_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.tpc.api.model.AcceptCarLoadDetailResponse value;
					
					value = new com.vip.tpc.api.model.AcceptCarLoadDetailResponse();
					com.vip.tpc.api.model.AcceptCarLoadDetailResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(acceptCarLoadDetail_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.tpc.api.model.AcceptCarLoadDetailResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(acceptCarLoadDetail_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class anormalExpress_resultHelper : TBeanSerializer<anormalExpress_result>
		{
			
			public static anormalExpress_resultHelper OBJ = new anormalExpress_resultHelper();
			
			public static anormalExpress_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(anormalExpress_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.tpc.api.model.AnormalExpressResponse value;
					
					value = new com.vip.tpc.api.model.AnormalExpressResponse();
					com.vip.tpc.api.model.AnormalExpressResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(anormalExpress_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.tpc.api.model.AnormalExpressResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(anormalExpress_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class carrierTakingAway_resultHelper : TBeanSerializer<carrierTakingAway_result>
		{
			
			public static carrierTakingAway_resultHelper OBJ = new carrierTakingAway_resultHelper();
			
			public static carrierTakingAway_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(carrierTakingAway_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.tpc.api.model.CarrierTakingAwayResponse value;
					
					value = new com.vip.tpc.api.model.CarrierTakingAwayResponse();
					com.vip.tpc.api.model.CarrierTakingAwayResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(carrierTakingAway_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.tpc.api.model.CarrierTakingAwayResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(carrierTakingAway_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class carrierTakingAwayGoods_resultHelper : TBeanSerializer<carrierTakingAwayGoods_result>
		{
			
			public static carrierTakingAwayGoods_resultHelper OBJ = new carrierTakingAwayGoods_resultHelper();
			
			public static carrierTakingAwayGoods_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(carrierTakingAwayGoods_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.tpc.api.model.CarrierTakingAwayGoodsResponse value;
					
					value = new com.vip.tpc.api.model.CarrierTakingAwayGoodsResponse();
					com.vip.tpc.api.model.CarrierTakingAwayGoodsResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(carrierTakingAwayGoods_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.tpc.api.model.CarrierTakingAwayGoodsResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(carrierTakingAwayGoods_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getReturnAddress_resultHelper : TBeanSerializer<getReturnAddress_result>
		{
			
			public static getReturnAddress_resultHelper OBJ = new getReturnAddress_resultHelper();
			
			public static getReturnAddress_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getReturnAddress_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.tpc.api.model.GetReturnAddressResponse value;
					
					value = new com.vip.tpc.api.model.GetReturnAddressResponse();
					com.vip.tpc.api.model.GetReturnAddressResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getReturnAddress_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.tpc.api.model.GetReturnAddressResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getReturnAddress_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getSerialNumberRelation_resultHelper : TBeanSerializer<getSerialNumberRelation_result>
		{
			
			public static getSerialNumberRelation_resultHelper OBJ = new getSerialNumberRelation_resultHelper();
			
			public static getSerialNumberRelation_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getSerialNumberRelation_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.tpc.api.model.GetSerialNumberRelationResponse value;
					
					value = new com.vip.tpc.api.model.GetSerialNumberRelationResponse();
					com.vip.tpc.api.model.GetSerialNumberRelationResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getSerialNumberRelation_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.tpc.api.model.GetSerialNumberRelationResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getSerialNumberRelation_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class healthCheck_resultHelper : TBeanSerializer<healthCheck_result>
		{
			
			public static healthCheck_resultHelper OBJ = new healthCheck_resultHelper();
			
			public static healthCheck_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(healthCheck_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.hermes.core.health.CheckResult value;
					
					value = new com.vip.hermes.core.health.CheckResult();
					com.vip.hermes.core.health.CheckResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(healthCheck_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.hermes.core.health.CheckResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(healthCheck_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class interceptReport_resultHelper : TBeanSerializer<interceptReport_result>
		{
			
			public static interceptReport_resultHelper OBJ = new interceptReport_resultHelper();
			
			public static interceptReport_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(interceptReport_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.tpc.api.model.InterceptReportResponse value;
					
					value = new com.vip.tpc.api.model.InterceptReportResponse();
					com.vip.tpc.api.model.InterceptReportResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(interceptReport_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.tpc.api.model.InterceptReportResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(interceptReport_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class packPhysicsAttribute_resultHelper : TBeanSerializer<packPhysicsAttribute_result>
		{
			
			public static packPhysicsAttribute_resultHelper OBJ = new packPhysicsAttribute_resultHelper();
			
			public static packPhysicsAttribute_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(packPhysicsAttribute_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.tpc.api.model.PackPhysicsAttributeResponse value;
					
					value = new com.vip.tpc.api.model.PackPhysicsAttributeResponse();
					com.vip.tpc.api.model.PackPhysicsAttributeResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(packPhysicsAttribute_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.tpc.api.model.PackPhysicsAttributeResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(packPhysicsAttribute_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class TpcExternalServiceClient : OspRestStub , TpcExternalService  {
			
			
			public TpcExternalServiceClient():base("vipapis.tpc.service.TpcExternalService","1.0.0") {
				
				
			}
			
			
			
			public com.vip.tpc.api.model.AcceptCarLoadDetailResponse acceptCarLoadDetail(com.vip.tpc.api.model.AcceptCarLoadDetailRequest acceptCarLoadDetailRequest_) {
				
				send_acceptCarLoadDetail(acceptCarLoadDetailRequest_);
				return recv_acceptCarLoadDetail(); 
				
			}
			
			
			private void send_acceptCarLoadDetail(com.vip.tpc.api.model.AcceptCarLoadDetailRequest acceptCarLoadDetailRequest_){
				
				InitInvocation("acceptCarLoadDetail");
				
				acceptCarLoadDetail_args args = new acceptCarLoadDetail_args();
				args.SetAcceptCarLoadDetailRequest(acceptCarLoadDetailRequest_);
				
				SendBase(args, acceptCarLoadDetail_argsHelper.getInstance());
			}
			
			
			private com.vip.tpc.api.model.AcceptCarLoadDetailResponse recv_acceptCarLoadDetail(){
				
				acceptCarLoadDetail_result result = new acceptCarLoadDetail_result();
				ReceiveBase(result, acceptCarLoadDetail_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.tpc.api.model.AnormalExpressResponse anormalExpress(com.vip.tpc.api.model.AnormalExpressRequest anormalExpressRequest_) {
				
				send_anormalExpress(anormalExpressRequest_);
				return recv_anormalExpress(); 
				
			}
			
			
			private void send_anormalExpress(com.vip.tpc.api.model.AnormalExpressRequest anormalExpressRequest_){
				
				InitInvocation("anormalExpress");
				
				anormalExpress_args args = new anormalExpress_args();
				args.SetAnormalExpressRequest(anormalExpressRequest_);
				
				SendBase(args, anormalExpress_argsHelper.getInstance());
			}
			
			
			private com.vip.tpc.api.model.AnormalExpressResponse recv_anormalExpress(){
				
				anormalExpress_result result = new anormalExpress_result();
				ReceiveBase(result, anormalExpress_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.tpc.api.model.CarrierTakingAwayResponse carrierTakingAway(com.vip.tpc.api.model.CarrierTakingAwayRequest carrierTakingAwayRequest_) {
				
				send_carrierTakingAway(carrierTakingAwayRequest_);
				return recv_carrierTakingAway(); 
				
			}
			
			
			private void send_carrierTakingAway(com.vip.tpc.api.model.CarrierTakingAwayRequest carrierTakingAwayRequest_){
				
				InitInvocation("carrierTakingAway");
				
				carrierTakingAway_args args = new carrierTakingAway_args();
				args.SetCarrierTakingAwayRequest(carrierTakingAwayRequest_);
				
				SendBase(args, carrierTakingAway_argsHelper.getInstance());
			}
			
			
			private com.vip.tpc.api.model.CarrierTakingAwayResponse recv_carrierTakingAway(){
				
				carrierTakingAway_result result = new carrierTakingAway_result();
				ReceiveBase(result, carrierTakingAway_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.tpc.api.model.CarrierTakingAwayGoodsResponse carrierTakingAwayGoods(com.vip.tpc.api.model.CarrierTakingAwayGoodsRequest carrierTakingAwayGoodsRequest_) {
				
				send_carrierTakingAwayGoods(carrierTakingAwayGoodsRequest_);
				return recv_carrierTakingAwayGoods(); 
				
			}
			
			
			private void send_carrierTakingAwayGoods(com.vip.tpc.api.model.CarrierTakingAwayGoodsRequest carrierTakingAwayGoodsRequest_){
				
				InitInvocation("carrierTakingAwayGoods");
				
				carrierTakingAwayGoods_args args = new carrierTakingAwayGoods_args();
				args.SetCarrierTakingAwayGoodsRequest(carrierTakingAwayGoodsRequest_);
				
				SendBase(args, carrierTakingAwayGoods_argsHelper.getInstance());
			}
			
			
			private com.vip.tpc.api.model.CarrierTakingAwayGoodsResponse recv_carrierTakingAwayGoods(){
				
				carrierTakingAwayGoods_result result = new carrierTakingAwayGoods_result();
				ReceiveBase(result, carrierTakingAwayGoods_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.tpc.api.model.GetReturnAddressResponse getReturnAddress(com.vip.tpc.api.model.GetReturnAddressRequest getReturnAddressRequest_) {
				
				send_getReturnAddress(getReturnAddressRequest_);
				return recv_getReturnAddress(); 
				
			}
			
			
			private void send_getReturnAddress(com.vip.tpc.api.model.GetReturnAddressRequest getReturnAddressRequest_){
				
				InitInvocation("getReturnAddress");
				
				getReturnAddress_args args = new getReturnAddress_args();
				args.SetGetReturnAddressRequest(getReturnAddressRequest_);
				
				SendBase(args, getReturnAddress_argsHelper.getInstance());
			}
			
			
			private com.vip.tpc.api.model.GetReturnAddressResponse recv_getReturnAddress(){
				
				getReturnAddress_result result = new getReturnAddress_result();
				ReceiveBase(result, getReturnAddress_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.tpc.api.model.GetSerialNumberRelationResponse getSerialNumberRelation(com.vip.tpc.api.model.GetSerialNumberRelationRequest getSerialNumberRelationRequest_) {
				
				send_getSerialNumberRelation(getSerialNumberRelationRequest_);
				return recv_getSerialNumberRelation(); 
				
			}
			
			
			private void send_getSerialNumberRelation(com.vip.tpc.api.model.GetSerialNumberRelationRequest getSerialNumberRelationRequest_){
				
				InitInvocation("getSerialNumberRelation");
				
				getSerialNumberRelation_args args = new getSerialNumberRelation_args();
				args.SetGetSerialNumberRelationRequest(getSerialNumberRelationRequest_);
				
				SendBase(args, getSerialNumberRelation_argsHelper.getInstance());
			}
			
			
			private com.vip.tpc.api.model.GetSerialNumberRelationResponse recv_getSerialNumberRelation(){
				
				getSerialNumberRelation_result result = new getSerialNumberRelation_result();
				ReceiveBase(result, getSerialNumberRelation_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.hermes.core.health.CheckResult healthCheck() {
				
				send_healthCheck();
				return recv_healthCheck(); 
				
			}
			
			
			private void send_healthCheck(){
				
				InitInvocation("healthCheck");
				
				healthCheck_args args = new healthCheck_args();
				
				SendBase(args, healthCheck_argsHelper.getInstance());
			}
			
			
			private com.vip.hermes.core.health.CheckResult recv_healthCheck(){
				
				healthCheck_result result = new healthCheck_result();
				ReceiveBase(result, healthCheck_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.tpc.api.model.InterceptReportResponse interceptReport(com.vip.tpc.api.model.InterceptReportRequest interceptReportRequest_) {
				
				send_interceptReport(interceptReportRequest_);
				return recv_interceptReport(); 
				
			}
			
			
			private void send_interceptReport(com.vip.tpc.api.model.InterceptReportRequest interceptReportRequest_){
				
				InitInvocation("interceptReport");
				
				interceptReport_args args = new interceptReport_args();
				args.SetInterceptReportRequest(interceptReportRequest_);
				
				SendBase(args, interceptReport_argsHelper.getInstance());
			}
			
			
			private com.vip.tpc.api.model.InterceptReportResponse recv_interceptReport(){
				
				interceptReport_result result = new interceptReport_result();
				ReceiveBase(result, interceptReport_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.tpc.api.model.PackPhysicsAttributeResponse packPhysicsAttribute(com.vip.tpc.api.model.PackPhysicsAttributeRequest packPhysicsAttributeRequest_) {
				
				send_packPhysicsAttribute(packPhysicsAttributeRequest_);
				return recv_packPhysicsAttribute(); 
				
			}
			
			
			private void send_packPhysicsAttribute(com.vip.tpc.api.model.PackPhysicsAttributeRequest packPhysicsAttributeRequest_){
				
				InitInvocation("packPhysicsAttribute");
				
				packPhysicsAttribute_args args = new packPhysicsAttribute_args();
				args.SetPackPhysicsAttributeRequest(packPhysicsAttributeRequest_);
				
				SendBase(args, packPhysicsAttribute_argsHelper.getInstance());
			}
			
			
			private com.vip.tpc.api.model.PackPhysicsAttributeResponse recv_packPhysicsAttribute(){
				
				packPhysicsAttribute_result result = new packPhysicsAttribute_result();
				ReceiveBase(result, packPhysicsAttribute_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
		}
		
		
	}
	
}