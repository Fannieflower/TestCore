using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace vipapis.otd.otdapi.service{
	
	
	public class VopReportServiceHelper {
		
		
		
		public class getDailyReports_args {
			
			///<summary>
			/// 广告主id
			///</summary>
			
			private string advertiser_id_;
			
			///<summary>
			/// VOP渠道枚举值
			///</summary>
			
			private com.vip.imp.otd.otdapi.service.VopDeliveryChannelType? channel_;
			
			///<summary>
			/// VOP报表级别枚举值
			///</summary>
			
			private com.vip.imp.otd.otdapi.service.VopReportLevel? level_;
			
			///<summary>
			/// 开始时间
			///</summary>
			
			private string start_date_;
			
			///<summary>
			/// 结束时间
			///</summary>
			
			private string end_date_;
			
			///<summary>
			/// 页码
			///</summary>
			
			private int? page_no_;
			
			///<summary>
			/// 每页记录数
			///</summary>
			
			private int? page_size_;
			
			public string GetAdvertiser_id(){
				return this.advertiser_id_;
			}
			
			public void SetAdvertiser_id(string value){
				this.advertiser_id_ = value;
			}
			public com.vip.imp.otd.otdapi.service.VopDeliveryChannelType? GetChannel(){
				return this.channel_;
			}
			
			public void SetChannel(com.vip.imp.otd.otdapi.service.VopDeliveryChannelType? value){
				this.channel_ = value;
			}
			public com.vip.imp.otd.otdapi.service.VopReportLevel? GetLevel(){
				return this.level_;
			}
			
			public void SetLevel(com.vip.imp.otd.otdapi.service.VopReportLevel? value){
				this.level_ = value;
			}
			public string GetStart_date(){
				return this.start_date_;
			}
			
			public void SetStart_date(string value){
				this.start_date_ = value;
			}
			public string GetEnd_date(){
				return this.end_date_;
			}
			
			public void SetEnd_date(string value){
				this.end_date_ = value;
			}
			public int? GetPage_no(){
				return this.page_no_;
			}
			
			public void SetPage_no(int? value){
				this.page_no_ = value;
			}
			public int? GetPage_size(){
				return this.page_size_;
			}
			
			public void SetPage_size(int? value){
				this.page_size_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class getDailyReports_result {
			
			///<summary>
			///</summary>
			
			private com.vip.imp.otd.otdapi.service.VopReportsModel success_;
			
			public com.vip.imp.otd.otdapi.service.VopReportsModel GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.imp.otd.otdapi.service.VopReportsModel value){
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
		
		
		
		
		
		public class getDailyReports_argsHelper : TBeanSerializer<getDailyReports_args>
		{
			
			public static getDailyReports_argsHelper OBJ = new getDailyReports_argsHelper();
			
			public static getDailyReports_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getDailyReports_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetAdvertiser_id(value);
				}
				
				
				
				
				
				if(true){
					
					com.vip.imp.otd.otdapi.service.VopDeliveryChannelType? value;
					
					value = com.vip.imp.otd.otdapi.service.VopDeliveryChannelTypeUtil.FindByName(iprot.ReadString());
					
					structs.SetChannel(value);
				}
				
				
				
				
				
				if(true){
					
					com.vip.imp.otd.otdapi.service.VopReportLevel? value;
					
					value = com.vip.imp.otd.otdapi.service.VopReportLevelUtil.FindByName(iprot.ReadString());
					
					structs.SetLevel(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetStart_date(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetEnd_date(value);
				}
				
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetPage_no(value);
				}
				
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetPage_size(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getDailyReports_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetAdvertiser_id() != null) {
					
					oprot.WriteFieldBegin("advertiser_id");
					oprot.WriteString(structs.GetAdvertiser_id());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetChannel() != null) {
					
					oprot.WriteFieldBegin("channel");
					oprot.WriteString(structs.GetChannel().ToString());  
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetLevel() != null) {
					
					oprot.WriteFieldBegin("level");
					oprot.WriteString(structs.GetLevel().ToString());  
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetStart_date() != null) {
					
					oprot.WriteFieldBegin("start_date");
					oprot.WriteString(structs.GetStart_date());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetEnd_date() != null) {
					
					oprot.WriteFieldBegin("end_date");
					oprot.WriteString(structs.GetEnd_date());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetPage_no() != null) {
					
					oprot.WriteFieldBegin("page_no");
					oprot.WriteI32((int)structs.GetPage_no()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("page_no can not be null!");
				}
				
				
				if(structs.GetPage_size() != null) {
					
					oprot.WriteFieldBegin("page_size");
					oprot.WriteI32((int)structs.GetPage_size()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("page_size can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getDailyReports_args bean){
				
				
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
		
		
		
		
		public class getDailyReports_resultHelper : TBeanSerializer<getDailyReports_result>
		{
			
			public static getDailyReports_resultHelper OBJ = new getDailyReports_resultHelper();
			
			public static getDailyReports_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getDailyReports_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.imp.otd.otdapi.service.VopReportsModel value;
					
					value = new com.vip.imp.otd.otdapi.service.VopReportsModel();
					com.vip.imp.otd.otdapi.service.VopReportsModelHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getDailyReports_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.imp.otd.otdapi.service.VopReportsModelHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getDailyReports_result bean){
				
				
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
		
		
		
		
		public class VopReportServiceClient : OspRestStub , VopReportService  {
			
			
			public VopReportServiceClient():base("vipapis.otd.otdapi.service.VopReportService","1.0.0") {
				
				
			}
			
			
			
			public com.vip.imp.otd.otdapi.service.VopReportsModel getDailyReports(string advertiser_id_,com.vip.imp.otd.otdapi.service.VopDeliveryChannelType? channel_,com.vip.imp.otd.otdapi.service.VopReportLevel? level_,string start_date_,string end_date_,int page_no_,int page_size_) {
				
				send_getDailyReports(advertiser_id_,channel_,level_,start_date_,end_date_,page_no_,page_size_);
				return recv_getDailyReports(); 
				
			}
			
			
			private void send_getDailyReports(string advertiser_id_,com.vip.imp.otd.otdapi.service.VopDeliveryChannelType? channel_,com.vip.imp.otd.otdapi.service.VopReportLevel? level_,string start_date_,string end_date_,int page_no_,int page_size_){
				
				InitInvocation("getDailyReports");
				
				getDailyReports_args args = new getDailyReports_args();
				args.SetAdvertiser_id(advertiser_id_);
				args.SetChannel(channel_);
				args.SetLevel(level_);
				args.SetStart_date(start_date_);
				args.SetEnd_date(end_date_);
				args.SetPage_no(page_no_);
				args.SetPage_size(page_size_);
				
				SendBase(args, getDailyReports_argsHelper.getInstance());
			}
			
			
			private com.vip.imp.otd.otdapi.service.VopReportsModel recv_getDailyReports(){
				
				getDailyReports_result result = new getDailyReports_result();
				ReceiveBase(result, getDailyReports_resultHelper.getInstance());
				
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
			
			
		}
		
		
	}
	
}