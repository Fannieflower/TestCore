using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace vipapis.fcs.ap.service{
	
	
	public class VspVendorBillAndDiscountServiceHelper {
		
		
		
		public class getBillDiscountDetailPage_args {
			
			///<summary>
			/// T-1货款明细请求参数
			///</summary>
			
			private com.vip.fcs.ap.service.BillAndDiscountDetailReqItem reqItem_;
			
			///<summary>
			/// 供应商编码,需跟reqItem对象vendorCode属性一致.
			///</summary>
			
			private string vendor_code_;
			
			public com.vip.fcs.ap.service.BillAndDiscountDetailReqItem GetReqItem(){
				return this.reqItem_;
			}
			
			public void SetReqItem(com.vip.fcs.ap.service.BillAndDiscountDetailReqItem value){
				this.reqItem_ = value;
			}
			public string GetVendor_code(){
				return this.vendor_code_;
			}
			
			public void SetVendor_code(string value){
				this.vendor_code_ = value;
			}
			
		}
		
		
		
		
		public class getBillDiscountSourcePage_args {
			
			///<summary>
			/// T-1货款明细请求参数
			///</summary>
			
			private com.vip.fcs.ap.service.BillAndDiscountDetailRealTimeReqItem reqItem_;
			
			///<summary>
			/// 供应商编码,需跟reqItem对象vendorCode属性一致.
			///</summary>
			
			private string vendor_code_;
			
			public com.vip.fcs.ap.service.BillAndDiscountDetailRealTimeReqItem GetReqItem(){
				return this.reqItem_;
			}
			
			public void SetReqItem(com.vip.fcs.ap.service.BillAndDiscountDetailRealTimeReqItem value){
				this.reqItem_ = value;
			}
			public string GetVendor_code(){
				return this.vendor_code_;
			}
			
			public void SetVendor_code(string value){
				this.vendor_code_ = value;
			}
			
		}
		
		
		
		
		public class getBillGoodsDetailPage_args {
			
			///<summary>
			/// 账单货款明细请求参数
			///</summary>
			
			private com.vip.fcs.ap.service.BillAndDiscountDetailReqItem reqItem_;
			
			///<summary>
			/// 供应商编码,需跟reqItem对象vendorCode属性一致.
			///</summary>
			
			private string vendor_code_;
			
			public com.vip.fcs.ap.service.BillAndDiscountDetailReqItem GetReqItem(){
				return this.reqItem_;
			}
			
			public void SetReqItem(com.vip.fcs.ap.service.BillAndDiscountDetailReqItem value){
				this.reqItem_ = value;
			}
			public string GetVendor_code(){
				return this.vendor_code_;
			}
			
			public void SetVendor_code(string value){
				this.vendor_code_ = value;
			}
			
		}
		
		
		
		
		public class getBillGoodsSourcePage_args {
			
			///<summary>
			/// 账单满减明细请求参数
			///</summary>
			
			private com.vip.fcs.ap.service.BillAndDiscountDetailRealTimeReqItem reqItem_;
			
			///<summary>
			/// 供应商编码,需跟reqItem对象vendorCode属性一致.
			///</summary>
			
			private string vendor_code_;
			
			public com.vip.fcs.ap.service.BillAndDiscountDetailRealTimeReqItem GetReqItem(){
				return this.reqItem_;
			}
			
			public void SetReqItem(com.vip.fcs.ap.service.BillAndDiscountDetailRealTimeReqItem value){
				this.reqItem_ = value;
			}
			public string GetVendor_code(){
				return this.vendor_code_;
			}
			
			public void SetVendor_code(string value){
				this.vendor_code_ = value;
			}
			
		}
		
		
		
		
		public class getInvTransDetailPage_args {
			
			///<summary>
			/// T-1货款明细请求参数
			///</summary>
			
			private com.vip.fcs.ap.service.InvTransDetailReqItem reqItem_;
			
			///<summary>
			/// 供应商编码,需跟reqItem对象vendorCode属性一致.
			///</summary>
			
			private string vendor_code_;
			
			public com.vip.fcs.ap.service.InvTransDetailReqItem GetReqItem(){
				return this.reqItem_;
			}
			
			public void SetReqItem(com.vip.fcs.ap.service.InvTransDetailReqItem value){
				this.reqItem_ = value;
			}
			public string GetVendor_code(){
				return this.vendor_code_;
			}
			
			public void SetVendor_code(string value){
				this.vendor_code_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class getBillDiscountDetailPage_result {
			
			///<summary>
			///</summary>
			
			private com.vip.fcs.ap.service.VendorDiscountDetailRespItem success_;
			
			public com.vip.fcs.ap.service.VendorDiscountDetailRespItem GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.fcs.ap.service.VendorDiscountDetailRespItem value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getBillDiscountSourcePage_result {
			
			///<summary>
			///</summary>
			
			private com.vip.fcs.ap.service.VendorDiscountSourceRespItem success_;
			
			public com.vip.fcs.ap.service.VendorDiscountSourceRespItem GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.fcs.ap.service.VendorDiscountSourceRespItem value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getBillGoodsDetailPage_result {
			
			///<summary>
			///</summary>
			
			private com.vip.fcs.ap.service.VendorBillDetailRespItem success_;
			
			public com.vip.fcs.ap.service.VendorBillDetailRespItem GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.fcs.ap.service.VendorBillDetailRespItem value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getBillGoodsSourcePage_result {
			
			///<summary>
			///</summary>
			
			private com.vip.fcs.ap.service.VendorBillSourceRespItem success_;
			
			public com.vip.fcs.ap.service.VendorBillSourceRespItem GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.fcs.ap.service.VendorBillSourceRespItem value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getInvTransDetailPage_result {
			
			///<summary>
			///</summary>
			
			private com.vip.fcs.ap.service.InvTransDetailRespItem success_;
			
			public com.vip.fcs.ap.service.InvTransDetailRespItem GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.fcs.ap.service.InvTransDetailRespItem value){
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
		
		
		
		
		
		public class getBillDiscountDetailPage_argsHelper : TBeanSerializer<getBillDiscountDetailPage_args>
		{
			
			public static getBillDiscountDetailPage_argsHelper OBJ = new getBillDiscountDetailPage_argsHelper();
			
			public static getBillDiscountDetailPage_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getBillDiscountDetailPage_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.fcs.ap.service.BillAndDiscountDetailReqItem value;
					
					value = new com.vip.fcs.ap.service.BillAndDiscountDetailReqItem();
					com.vip.fcs.ap.service.BillAndDiscountDetailReqItemHelper.getInstance().Read(value, iprot);
					
					structs.SetReqItem(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetVendor_code(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getBillDiscountDetailPage_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReqItem() != null) {
					
					oprot.WriteFieldBegin("reqItem");
					
					com.vip.fcs.ap.service.BillAndDiscountDetailReqItemHelper.getInstance().Write(structs.GetReqItem(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetVendor_code() != null) {
					
					oprot.WriteFieldBegin("vendor_code");
					oprot.WriteString(structs.GetVendor_code());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("vendor_code can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getBillDiscountDetailPage_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getBillDiscountSourcePage_argsHelper : TBeanSerializer<getBillDiscountSourcePage_args>
		{
			
			public static getBillDiscountSourcePage_argsHelper OBJ = new getBillDiscountSourcePage_argsHelper();
			
			public static getBillDiscountSourcePage_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getBillDiscountSourcePage_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.fcs.ap.service.BillAndDiscountDetailRealTimeReqItem value;
					
					value = new com.vip.fcs.ap.service.BillAndDiscountDetailRealTimeReqItem();
					com.vip.fcs.ap.service.BillAndDiscountDetailRealTimeReqItemHelper.getInstance().Read(value, iprot);
					
					structs.SetReqItem(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetVendor_code(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getBillDiscountSourcePage_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReqItem() != null) {
					
					oprot.WriteFieldBegin("reqItem");
					
					com.vip.fcs.ap.service.BillAndDiscountDetailRealTimeReqItemHelper.getInstance().Write(structs.GetReqItem(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetVendor_code() != null) {
					
					oprot.WriteFieldBegin("vendor_code");
					oprot.WriteString(structs.GetVendor_code());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("vendor_code can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getBillDiscountSourcePage_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getBillGoodsDetailPage_argsHelper : TBeanSerializer<getBillGoodsDetailPage_args>
		{
			
			public static getBillGoodsDetailPage_argsHelper OBJ = new getBillGoodsDetailPage_argsHelper();
			
			public static getBillGoodsDetailPage_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getBillGoodsDetailPage_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.fcs.ap.service.BillAndDiscountDetailReqItem value;
					
					value = new com.vip.fcs.ap.service.BillAndDiscountDetailReqItem();
					com.vip.fcs.ap.service.BillAndDiscountDetailReqItemHelper.getInstance().Read(value, iprot);
					
					structs.SetReqItem(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetVendor_code(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getBillGoodsDetailPage_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReqItem() != null) {
					
					oprot.WriteFieldBegin("reqItem");
					
					com.vip.fcs.ap.service.BillAndDiscountDetailReqItemHelper.getInstance().Write(structs.GetReqItem(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetVendor_code() != null) {
					
					oprot.WriteFieldBegin("vendor_code");
					oprot.WriteString(structs.GetVendor_code());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("vendor_code can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getBillGoodsDetailPage_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getBillGoodsSourcePage_argsHelper : TBeanSerializer<getBillGoodsSourcePage_args>
		{
			
			public static getBillGoodsSourcePage_argsHelper OBJ = new getBillGoodsSourcePage_argsHelper();
			
			public static getBillGoodsSourcePage_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getBillGoodsSourcePage_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.fcs.ap.service.BillAndDiscountDetailRealTimeReqItem value;
					
					value = new com.vip.fcs.ap.service.BillAndDiscountDetailRealTimeReqItem();
					com.vip.fcs.ap.service.BillAndDiscountDetailRealTimeReqItemHelper.getInstance().Read(value, iprot);
					
					structs.SetReqItem(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetVendor_code(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getBillGoodsSourcePage_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReqItem() != null) {
					
					oprot.WriteFieldBegin("reqItem");
					
					com.vip.fcs.ap.service.BillAndDiscountDetailRealTimeReqItemHelper.getInstance().Write(structs.GetReqItem(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetVendor_code() != null) {
					
					oprot.WriteFieldBegin("vendor_code");
					oprot.WriteString(structs.GetVendor_code());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("vendor_code can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getBillGoodsSourcePage_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getInvTransDetailPage_argsHelper : TBeanSerializer<getInvTransDetailPage_args>
		{
			
			public static getInvTransDetailPage_argsHelper OBJ = new getInvTransDetailPage_argsHelper();
			
			public static getInvTransDetailPage_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getInvTransDetailPage_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.fcs.ap.service.InvTransDetailReqItem value;
					
					value = new com.vip.fcs.ap.service.InvTransDetailReqItem();
					com.vip.fcs.ap.service.InvTransDetailReqItemHelper.getInstance().Read(value, iprot);
					
					structs.SetReqItem(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetVendor_code(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getInvTransDetailPage_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReqItem() != null) {
					
					oprot.WriteFieldBegin("reqItem");
					
					com.vip.fcs.ap.service.InvTransDetailReqItemHelper.getInstance().Write(structs.GetReqItem(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetVendor_code() != null) {
					
					oprot.WriteFieldBegin("vendor_code");
					oprot.WriteString(structs.GetVendor_code());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("vendor_code can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getInvTransDetailPage_args bean){
				
				
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
		
		
		
		
		public class getBillDiscountDetailPage_resultHelper : TBeanSerializer<getBillDiscountDetailPage_result>
		{
			
			public static getBillDiscountDetailPage_resultHelper OBJ = new getBillDiscountDetailPage_resultHelper();
			
			public static getBillDiscountDetailPage_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getBillDiscountDetailPage_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.fcs.ap.service.VendorDiscountDetailRespItem value;
					
					value = new com.vip.fcs.ap.service.VendorDiscountDetailRespItem();
					com.vip.fcs.ap.service.VendorDiscountDetailRespItemHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getBillDiscountDetailPage_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.fcs.ap.service.VendorDiscountDetailRespItemHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getBillDiscountDetailPage_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getBillDiscountSourcePage_resultHelper : TBeanSerializer<getBillDiscountSourcePage_result>
		{
			
			public static getBillDiscountSourcePage_resultHelper OBJ = new getBillDiscountSourcePage_resultHelper();
			
			public static getBillDiscountSourcePage_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getBillDiscountSourcePage_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.fcs.ap.service.VendorDiscountSourceRespItem value;
					
					value = new com.vip.fcs.ap.service.VendorDiscountSourceRespItem();
					com.vip.fcs.ap.service.VendorDiscountSourceRespItemHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getBillDiscountSourcePage_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.fcs.ap.service.VendorDiscountSourceRespItemHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getBillDiscountSourcePage_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getBillGoodsDetailPage_resultHelper : TBeanSerializer<getBillGoodsDetailPage_result>
		{
			
			public static getBillGoodsDetailPage_resultHelper OBJ = new getBillGoodsDetailPage_resultHelper();
			
			public static getBillGoodsDetailPage_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getBillGoodsDetailPage_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.fcs.ap.service.VendorBillDetailRespItem value;
					
					value = new com.vip.fcs.ap.service.VendorBillDetailRespItem();
					com.vip.fcs.ap.service.VendorBillDetailRespItemHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getBillGoodsDetailPage_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.fcs.ap.service.VendorBillDetailRespItemHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getBillGoodsDetailPage_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getBillGoodsSourcePage_resultHelper : TBeanSerializer<getBillGoodsSourcePage_result>
		{
			
			public static getBillGoodsSourcePage_resultHelper OBJ = new getBillGoodsSourcePage_resultHelper();
			
			public static getBillGoodsSourcePage_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getBillGoodsSourcePage_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.fcs.ap.service.VendorBillSourceRespItem value;
					
					value = new com.vip.fcs.ap.service.VendorBillSourceRespItem();
					com.vip.fcs.ap.service.VendorBillSourceRespItemHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getBillGoodsSourcePage_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.fcs.ap.service.VendorBillSourceRespItemHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getBillGoodsSourcePage_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getInvTransDetailPage_resultHelper : TBeanSerializer<getInvTransDetailPage_result>
		{
			
			public static getInvTransDetailPage_resultHelper OBJ = new getInvTransDetailPage_resultHelper();
			
			public static getInvTransDetailPage_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getInvTransDetailPage_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.fcs.ap.service.InvTransDetailRespItem value;
					
					value = new com.vip.fcs.ap.service.InvTransDetailRespItem();
					com.vip.fcs.ap.service.InvTransDetailRespItemHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getInvTransDetailPage_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.fcs.ap.service.InvTransDetailRespItemHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getInvTransDetailPage_result bean){
				
				
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
		
		
		
		
		public class VspVendorBillAndDiscountServiceClient : OspRestStub , VspVendorBillAndDiscountService  {
			
			
			public VspVendorBillAndDiscountServiceClient():base("vipapis.fcs.ap.service.VspVendorBillAndDiscountService","1.1.0") {
				
				
			}
			
			
			
			public com.vip.fcs.ap.service.VendorDiscountDetailRespItem getBillDiscountDetailPage(com.vip.fcs.ap.service.BillAndDiscountDetailReqItem reqItem_,string vendor_code_) {
				
				send_getBillDiscountDetailPage(reqItem_,vendor_code_);
				return recv_getBillDiscountDetailPage(); 
				
			}
			
			
			private void send_getBillDiscountDetailPage(com.vip.fcs.ap.service.BillAndDiscountDetailReqItem reqItem_,string vendor_code_){
				
				InitInvocation("getBillDiscountDetailPage");
				
				getBillDiscountDetailPage_args args = new getBillDiscountDetailPage_args();
				args.SetReqItem(reqItem_);
				args.SetVendor_code(vendor_code_);
				
				SendBase(args, getBillDiscountDetailPage_argsHelper.getInstance());
			}
			
			
			private com.vip.fcs.ap.service.VendorDiscountDetailRespItem recv_getBillDiscountDetailPage(){
				
				getBillDiscountDetailPage_result result = new getBillDiscountDetailPage_result();
				ReceiveBase(result, getBillDiscountDetailPage_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.fcs.ap.service.VendorDiscountSourceRespItem getBillDiscountSourcePage(com.vip.fcs.ap.service.BillAndDiscountDetailRealTimeReqItem reqItem_,string vendor_code_) {
				
				send_getBillDiscountSourcePage(reqItem_,vendor_code_);
				return recv_getBillDiscountSourcePage(); 
				
			}
			
			
			private void send_getBillDiscountSourcePage(com.vip.fcs.ap.service.BillAndDiscountDetailRealTimeReqItem reqItem_,string vendor_code_){
				
				InitInvocation("getBillDiscountSourcePage");
				
				getBillDiscountSourcePage_args args = new getBillDiscountSourcePage_args();
				args.SetReqItem(reqItem_);
				args.SetVendor_code(vendor_code_);
				
				SendBase(args, getBillDiscountSourcePage_argsHelper.getInstance());
			}
			
			
			private com.vip.fcs.ap.service.VendorDiscountSourceRespItem recv_getBillDiscountSourcePage(){
				
				getBillDiscountSourcePage_result result = new getBillDiscountSourcePage_result();
				ReceiveBase(result, getBillDiscountSourcePage_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.fcs.ap.service.VendorBillDetailRespItem getBillGoodsDetailPage(com.vip.fcs.ap.service.BillAndDiscountDetailReqItem reqItem_,string vendor_code_) {
				
				send_getBillGoodsDetailPage(reqItem_,vendor_code_);
				return recv_getBillGoodsDetailPage(); 
				
			}
			
			
			private void send_getBillGoodsDetailPage(com.vip.fcs.ap.service.BillAndDiscountDetailReqItem reqItem_,string vendor_code_){
				
				InitInvocation("getBillGoodsDetailPage");
				
				getBillGoodsDetailPage_args args = new getBillGoodsDetailPage_args();
				args.SetReqItem(reqItem_);
				args.SetVendor_code(vendor_code_);
				
				SendBase(args, getBillGoodsDetailPage_argsHelper.getInstance());
			}
			
			
			private com.vip.fcs.ap.service.VendorBillDetailRespItem recv_getBillGoodsDetailPage(){
				
				getBillGoodsDetailPage_result result = new getBillGoodsDetailPage_result();
				ReceiveBase(result, getBillGoodsDetailPage_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.fcs.ap.service.VendorBillSourceRespItem getBillGoodsSourcePage(com.vip.fcs.ap.service.BillAndDiscountDetailRealTimeReqItem reqItem_,string vendor_code_) {
				
				send_getBillGoodsSourcePage(reqItem_,vendor_code_);
				return recv_getBillGoodsSourcePage(); 
				
			}
			
			
			private void send_getBillGoodsSourcePage(com.vip.fcs.ap.service.BillAndDiscountDetailRealTimeReqItem reqItem_,string vendor_code_){
				
				InitInvocation("getBillGoodsSourcePage");
				
				getBillGoodsSourcePage_args args = new getBillGoodsSourcePage_args();
				args.SetReqItem(reqItem_);
				args.SetVendor_code(vendor_code_);
				
				SendBase(args, getBillGoodsSourcePage_argsHelper.getInstance());
			}
			
			
			private com.vip.fcs.ap.service.VendorBillSourceRespItem recv_getBillGoodsSourcePage(){
				
				getBillGoodsSourcePage_result result = new getBillGoodsSourcePage_result();
				ReceiveBase(result, getBillGoodsSourcePage_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.fcs.ap.service.InvTransDetailRespItem getInvTransDetailPage(com.vip.fcs.ap.service.InvTransDetailReqItem reqItem_,string vendor_code_) {
				
				send_getInvTransDetailPage(reqItem_,vendor_code_);
				return recv_getInvTransDetailPage(); 
				
			}
			
			
			private void send_getInvTransDetailPage(com.vip.fcs.ap.service.InvTransDetailReqItem reqItem_,string vendor_code_){
				
				InitInvocation("getInvTransDetailPage");
				
				getInvTransDetailPage_args args = new getInvTransDetailPage_args();
				args.SetReqItem(reqItem_);
				args.SetVendor_code(vendor_code_);
				
				SendBase(args, getInvTransDetailPage_argsHelper.getInstance());
			}
			
			
			private com.vip.fcs.ap.service.InvTransDetailRespItem recv_getInvTransDetailPage(){
				
				getInvTransDetailPage_result result = new getInvTransDetailPage_result();
				ReceiveBase(result, getInvTransDetailPage_resultHelper.getInstance());
				
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