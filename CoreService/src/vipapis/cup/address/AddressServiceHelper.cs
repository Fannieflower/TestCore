using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace vipapis.cup.address{
	
	
	public class AddressServiceHelper {
		
		
		
		public class getVipAddress_args {
			
			///<summary>
			/// 省名称
			///</summary>
			
			private string province_;
			
			///<summary>
			/// 城市名称
			///</summary>
			
			private string city_;
			
			///<summary>
			/// 区/县名称
			///</summary>
			
			private string county_;
			
			///<summary>
			/// 镇/街道名称
			///</summary>
			
			private string street_;
			
			public string GetProvince(){
				return this.province_;
			}
			
			public void SetProvince(string value){
				this.province_ = value;
			}
			public string GetCity(){
				return this.city_;
			}
			
			public void SetCity(string value){
				this.city_ = value;
			}
			public string GetCounty(){
				return this.county_;
			}
			
			public void SetCounty(string value){
				this.county_ = value;
			}
			public string GetStreet(){
				return this.street_;
			}
			
			public void SetStreet(string value){
				this.street_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class getVipAddress_result {
			
			///<summary>
			///</summary>
			
			private com.vip.vop.cup.api.address.VipAddressInfo success_;
			
			public com.vip.vop.cup.api.address.VipAddressInfo GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.vop.cup.api.address.VipAddressInfo value){
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
		
		
		
		
		
		public class getVipAddress_argsHelper : TBeanSerializer<getVipAddress_args>
		{
			
			public static getVipAddress_argsHelper OBJ = new getVipAddress_argsHelper();
			
			public static getVipAddress_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getVipAddress_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetProvince(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetCity(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetCounty(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetStreet(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getVipAddress_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetProvince() != null) {
					
					oprot.WriteFieldBegin("province");
					oprot.WriteString(structs.GetProvince());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("province can not be null!");
				}
				
				
				if(structs.GetCity() != null) {
					
					oprot.WriteFieldBegin("city");
					oprot.WriteString(structs.GetCity());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("city can not be null!");
				}
				
				
				if(structs.GetCounty() != null) {
					
					oprot.WriteFieldBegin("county");
					oprot.WriteString(structs.GetCounty());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("county can not be null!");
				}
				
				
				if(structs.GetStreet() != null) {
					
					oprot.WriteFieldBegin("street");
					oprot.WriteString(structs.GetStreet());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getVipAddress_args bean){
				
				
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
		
		
		
		
		public class getVipAddress_resultHelper : TBeanSerializer<getVipAddress_result>
		{
			
			public static getVipAddress_resultHelper OBJ = new getVipAddress_resultHelper();
			
			public static getVipAddress_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getVipAddress_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.vop.cup.api.address.VipAddressInfo value;
					
					value = new com.vip.vop.cup.api.address.VipAddressInfo();
					com.vip.vop.cup.api.address.VipAddressInfoHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getVipAddress_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.vop.cup.api.address.VipAddressInfoHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getVipAddress_result bean){
				
				
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
		
		
		
		
		public class AddressServiceClient : OspRestStub , AddressService  {
			
			
			public AddressServiceClient():base("vipapis.cup.address.AddressService","1.0.0") {
				
				
			}
			
			
			
			public com.vip.vop.cup.api.address.VipAddressInfo getVipAddress(string province_,string city_,string county_,string street_) {
				
				send_getVipAddress(province_,city_,county_,street_);
				return recv_getVipAddress(); 
				
			}
			
			
			private void send_getVipAddress(string province_,string city_,string county_,string street_){
				
				InitInvocation("getVipAddress");
				
				getVipAddress_args args = new getVipAddress_args();
				args.SetProvince(province_);
				args.SetCity(city_);
				args.SetCounty(county_);
				args.SetStreet(street_);
				
				SendBase(args, getVipAddress_argsHelper.getInstance());
			}
			
			
			private com.vip.vop.cup.api.address.VipAddressInfo recv_getVipAddress(){
				
				getVipAddress_result result = new getVipAddress_result();
				ReceiveBase(result, getVipAddress_resultHelper.getInstance());
				
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