using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace com.vip.xstore.user.face.service{
	
	
	public class XstoreCameraInfoServiceHelper {
		
		
		
		public class batchDeleteCamera_args {
			
			///<summary>
			///</summary>
			
			private com.vip.xstore.user.face.service.XstoreCameraBatchDelParam delParam_;
			
			public com.vip.xstore.user.face.service.XstoreCameraBatchDelParam GetDelParam(){
				return this.delParam_;
			}
			
			public void SetDelParam(com.vip.xstore.user.face.service.XstoreCameraBatchDelParam value){
				this.delParam_ = value;
			}
			
		}
		
		
		
		
		public class createCamera_args {
			
			///<summary>
			///</summary>
			
			private com.vip.xstore.user.face.service.XstoreCameraInfoModel xstoreCameraInfoModel_;
			
			public com.vip.xstore.user.face.service.XstoreCameraInfoModel GetXstoreCameraInfoModel(){
				return this.xstoreCameraInfoModel_;
			}
			
			public void SetXstoreCameraInfoModel(com.vip.xstore.user.face.service.XstoreCameraInfoModel value){
				this.xstoreCameraInfoModel_ = value;
			}
			
		}
		
		
		
		
		public class deleteCamera_args {
			
			///<summary>
			///</summary>
			
			private com.vip.xstore.user.face.service.XstoreCameraDelParam delParam_;
			
			public com.vip.xstore.user.face.service.XstoreCameraDelParam GetDelParam(){
				return this.delParam_;
			}
			
			public void SetDelParam(com.vip.xstore.user.face.service.XstoreCameraDelParam value){
				this.delParam_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class queryCameraList_args {
			
			///<summary>
			///</summary>
			
			private com.vip.xstore.user.face.service.XstoreCameraPageReqParam pageReqParam_;
			
			public com.vip.xstore.user.face.service.XstoreCameraPageReqParam GetPageReqParam(){
				return this.pageReqParam_;
			}
			
			public void SetPageReqParam(com.vip.xstore.user.face.service.XstoreCameraPageReqParam value){
				this.pageReqParam_ = value;
			}
			
		}
		
		
		
		
		public class selectCameraStateLog_args {
			
			///<summary>
			///</summary>
			
			private com.vip.xstore.user.face.service.XstoreCameraStateLogReqParam pageReqParam_;
			
			public com.vip.xstore.user.face.service.XstoreCameraStateLogReqParam GetPageReqParam(){
				return this.pageReqParam_;
			}
			
			public void SetPageReqParam(com.vip.xstore.user.face.service.XstoreCameraStateLogReqParam value){
				this.pageReqParam_ = value;
			}
			
		}
		
		
		
		
		public class updateCamera_args {
			
			///<summary>
			///</summary>
			
			private com.vip.xstore.user.face.service.XstoreCameraUpdateParam updateParam_;
			
			public com.vip.xstore.user.face.service.XstoreCameraUpdateParam GetUpdateParam(){
				return this.updateParam_;
			}
			
			public void SetUpdateParam(com.vip.xstore.user.face.service.XstoreCameraUpdateParam value){
				this.updateParam_ = value;
			}
			
		}
		
		
		
		
		public class uploadCameraStateLog_args {
			
			///<summary>
			///</summary>
			
			private com.vip.xstore.user.face.service.XstoreCameraStateLogParam xstoreCameraStateLogParam_;
			
			public com.vip.xstore.user.face.service.XstoreCameraStateLogParam GetXstoreCameraStateLogParam(){
				return this.xstoreCameraStateLogParam_;
			}
			
			public void SetXstoreCameraStateLogParam(com.vip.xstore.user.face.service.XstoreCameraStateLogParam value){
				this.xstoreCameraStateLogParam_ = value;
			}
			
		}
		
		
		
		
		public class batchDeleteCamera_result {
			
			///<summary>
			///</summary>
			
			private int? success_;
			
			public int? GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(int? value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class createCamera_result {
			
			///<summary>
			///</summary>
			
			private int? success_;
			
			public int? GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(int? value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class deleteCamera_result {
			
			///<summary>
			///</summary>
			
			private int? success_;
			
			public int? GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(int? value){
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
		
		
		
		
		public class queryCameraList_result {
			
			///<summary>
			///</summary>
			
			private com.vip.xstore.user.face.service.XstoreCameraInfoListResult success_;
			
			public com.vip.xstore.user.face.service.XstoreCameraInfoListResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.xstore.user.face.service.XstoreCameraInfoListResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class selectCameraStateLog_result {
			
			///<summary>
			///</summary>
			
			private com.vip.xstore.user.face.service.XstoreCameraStateLogListResult success_;
			
			public com.vip.xstore.user.face.service.XstoreCameraStateLogListResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.xstore.user.face.service.XstoreCameraStateLogListResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class updateCamera_result {
			
			///<summary>
			///</summary>
			
			private int? success_;
			
			public int? GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(int? value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class uploadCameraStateLog_result {
			
			///<summary>
			///</summary>
			
			private com.vip.xstore.user.face.service.XstoreCameraStateLogUploadResult success_;
			
			public com.vip.xstore.user.face.service.XstoreCameraStateLogUploadResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.xstore.user.face.service.XstoreCameraStateLogUploadResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		
		public class batchDeleteCamera_argsHelper : TBeanSerializer<batchDeleteCamera_args>
		{
			
			public static batchDeleteCamera_argsHelper OBJ = new batchDeleteCamera_argsHelper();
			
			public static batchDeleteCamera_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(batchDeleteCamera_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.user.face.service.XstoreCameraBatchDelParam value;
					
					value = new com.vip.xstore.user.face.service.XstoreCameraBatchDelParam();
					com.vip.xstore.user.face.service.XstoreCameraBatchDelParamHelper.getInstance().Read(value, iprot);
					
					structs.SetDelParam(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(batchDeleteCamera_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetDelParam() != null) {
					
					oprot.WriteFieldBegin("delParam");
					
					com.vip.xstore.user.face.service.XstoreCameraBatchDelParamHelper.getInstance().Write(structs.GetDelParam(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("delParam can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(batchDeleteCamera_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class createCamera_argsHelper : TBeanSerializer<createCamera_args>
		{
			
			public static createCamera_argsHelper OBJ = new createCamera_argsHelper();
			
			public static createCamera_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(createCamera_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.user.face.service.XstoreCameraInfoModel value;
					
					value = new com.vip.xstore.user.face.service.XstoreCameraInfoModel();
					com.vip.xstore.user.face.service.XstoreCameraInfoModelHelper.getInstance().Read(value, iprot);
					
					structs.SetXstoreCameraInfoModel(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(createCamera_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetXstoreCameraInfoModel() != null) {
					
					oprot.WriteFieldBegin("xstoreCameraInfoModel");
					
					com.vip.xstore.user.face.service.XstoreCameraInfoModelHelper.getInstance().Write(structs.GetXstoreCameraInfoModel(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("xstoreCameraInfoModel can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(createCamera_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class deleteCamera_argsHelper : TBeanSerializer<deleteCamera_args>
		{
			
			public static deleteCamera_argsHelper OBJ = new deleteCamera_argsHelper();
			
			public static deleteCamera_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(deleteCamera_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.user.face.service.XstoreCameraDelParam value;
					
					value = new com.vip.xstore.user.face.service.XstoreCameraDelParam();
					com.vip.xstore.user.face.service.XstoreCameraDelParamHelper.getInstance().Read(value, iprot);
					
					structs.SetDelParam(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(deleteCamera_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetDelParam() != null) {
					
					oprot.WriteFieldBegin("delParam");
					
					com.vip.xstore.user.face.service.XstoreCameraDelParamHelper.getInstance().Write(structs.GetDelParam(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("delParam can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(deleteCamera_args bean){
				
				
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
		
		
		
		
		public class queryCameraList_argsHelper : TBeanSerializer<queryCameraList_args>
		{
			
			public static queryCameraList_argsHelper OBJ = new queryCameraList_argsHelper();
			
			public static queryCameraList_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryCameraList_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.user.face.service.XstoreCameraPageReqParam value;
					
					value = new com.vip.xstore.user.face.service.XstoreCameraPageReqParam();
					com.vip.xstore.user.face.service.XstoreCameraPageReqParamHelper.getInstance().Read(value, iprot);
					
					structs.SetPageReqParam(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryCameraList_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPageReqParam() != null) {
					
					oprot.WriteFieldBegin("pageReqParam");
					
					com.vip.xstore.user.face.service.XstoreCameraPageReqParamHelper.getInstance().Write(structs.GetPageReqParam(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("pageReqParam can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryCameraList_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class selectCameraStateLog_argsHelper : TBeanSerializer<selectCameraStateLog_args>
		{
			
			public static selectCameraStateLog_argsHelper OBJ = new selectCameraStateLog_argsHelper();
			
			public static selectCameraStateLog_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(selectCameraStateLog_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.user.face.service.XstoreCameraStateLogReqParam value;
					
					value = new com.vip.xstore.user.face.service.XstoreCameraStateLogReqParam();
					com.vip.xstore.user.face.service.XstoreCameraStateLogReqParamHelper.getInstance().Read(value, iprot);
					
					structs.SetPageReqParam(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(selectCameraStateLog_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPageReqParam() != null) {
					
					oprot.WriteFieldBegin("pageReqParam");
					
					com.vip.xstore.user.face.service.XstoreCameraStateLogReqParamHelper.getInstance().Write(structs.GetPageReqParam(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("pageReqParam can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(selectCameraStateLog_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateCamera_argsHelper : TBeanSerializer<updateCamera_args>
		{
			
			public static updateCamera_argsHelper OBJ = new updateCamera_argsHelper();
			
			public static updateCamera_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateCamera_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.user.face.service.XstoreCameraUpdateParam value;
					
					value = new com.vip.xstore.user.face.service.XstoreCameraUpdateParam();
					com.vip.xstore.user.face.service.XstoreCameraUpdateParamHelper.getInstance().Read(value, iprot);
					
					structs.SetUpdateParam(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateCamera_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetUpdateParam() != null) {
					
					oprot.WriteFieldBegin("updateParam");
					
					com.vip.xstore.user.face.service.XstoreCameraUpdateParamHelper.getInstance().Write(structs.GetUpdateParam(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("updateParam can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateCamera_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class uploadCameraStateLog_argsHelper : TBeanSerializer<uploadCameraStateLog_args>
		{
			
			public static uploadCameraStateLog_argsHelper OBJ = new uploadCameraStateLog_argsHelper();
			
			public static uploadCameraStateLog_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(uploadCameraStateLog_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.user.face.service.XstoreCameraStateLogParam value;
					
					value = new com.vip.xstore.user.face.service.XstoreCameraStateLogParam();
					com.vip.xstore.user.face.service.XstoreCameraStateLogParamHelper.getInstance().Read(value, iprot);
					
					structs.SetXstoreCameraStateLogParam(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(uploadCameraStateLog_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetXstoreCameraStateLogParam() != null) {
					
					oprot.WriteFieldBegin("xstoreCameraStateLogParam");
					
					com.vip.xstore.user.face.service.XstoreCameraStateLogParamHelper.getInstance().Write(structs.GetXstoreCameraStateLogParam(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("xstoreCameraStateLogParam can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(uploadCameraStateLog_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class batchDeleteCamera_resultHelper : TBeanSerializer<batchDeleteCamera_result>
		{
			
			public static batchDeleteCamera_resultHelper OBJ = new batchDeleteCamera_resultHelper();
			
			public static batchDeleteCamera_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(batchDeleteCamera_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(batchDeleteCamera_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteI32((int)structs.GetSuccess()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("success can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(batchDeleteCamera_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class createCamera_resultHelper : TBeanSerializer<createCamera_result>
		{
			
			public static createCamera_resultHelper OBJ = new createCamera_resultHelper();
			
			public static createCamera_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(createCamera_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(createCamera_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteI32((int)structs.GetSuccess()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("success can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(createCamera_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class deleteCamera_resultHelper : TBeanSerializer<deleteCamera_result>
		{
			
			public static deleteCamera_resultHelper OBJ = new deleteCamera_resultHelper();
			
			public static deleteCamera_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(deleteCamera_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(deleteCamera_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteI32((int)structs.GetSuccess()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("success can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(deleteCamera_result bean){
				
				
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
		
		
		
		
		public class queryCameraList_resultHelper : TBeanSerializer<queryCameraList_result>
		{
			
			public static queryCameraList_resultHelper OBJ = new queryCameraList_resultHelper();
			
			public static queryCameraList_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryCameraList_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.user.face.service.XstoreCameraInfoListResult value;
					
					value = new com.vip.xstore.user.face.service.XstoreCameraInfoListResult();
					com.vip.xstore.user.face.service.XstoreCameraInfoListResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryCameraList_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.xstore.user.face.service.XstoreCameraInfoListResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryCameraList_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class selectCameraStateLog_resultHelper : TBeanSerializer<selectCameraStateLog_result>
		{
			
			public static selectCameraStateLog_resultHelper OBJ = new selectCameraStateLog_resultHelper();
			
			public static selectCameraStateLog_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(selectCameraStateLog_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.user.face.service.XstoreCameraStateLogListResult value;
					
					value = new com.vip.xstore.user.face.service.XstoreCameraStateLogListResult();
					com.vip.xstore.user.face.service.XstoreCameraStateLogListResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(selectCameraStateLog_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.xstore.user.face.service.XstoreCameraStateLogListResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(selectCameraStateLog_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updateCamera_resultHelper : TBeanSerializer<updateCamera_result>
		{
			
			public static updateCamera_resultHelper OBJ = new updateCamera_resultHelper();
			
			public static updateCamera_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updateCamera_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updateCamera_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteI32((int)structs.GetSuccess()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("success can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updateCamera_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class uploadCameraStateLog_resultHelper : TBeanSerializer<uploadCameraStateLog_result>
		{
			
			public static uploadCameraStateLog_resultHelper OBJ = new uploadCameraStateLog_resultHelper();
			
			public static uploadCameraStateLog_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(uploadCameraStateLog_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.xstore.user.face.service.XstoreCameraStateLogUploadResult value;
					
					value = new com.vip.xstore.user.face.service.XstoreCameraStateLogUploadResult();
					com.vip.xstore.user.face.service.XstoreCameraStateLogUploadResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(uploadCameraStateLog_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.xstore.user.face.service.XstoreCameraStateLogUploadResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(uploadCameraStateLog_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class XstoreCameraInfoServiceClient : OspRestStub , XstoreCameraInfoService  {
			
			
			public XstoreCameraInfoServiceClient():base("com.vip.xstore.user.face.service.XstoreCameraInfoService","1.0.0") {
				
				
			}
			
			
			
			public int? batchDeleteCamera(com.vip.xstore.user.face.service.XstoreCameraBatchDelParam delParam_) {
				
				send_batchDeleteCamera(delParam_);
				return recv_batchDeleteCamera(); 
				
			}
			
			
			private void send_batchDeleteCamera(com.vip.xstore.user.face.service.XstoreCameraBatchDelParam delParam_){
				
				InitInvocation("batchDeleteCamera");
				
				batchDeleteCamera_args args = new batchDeleteCamera_args();
				args.SetDelParam(delParam_);
				
				SendBase(args, batchDeleteCamera_argsHelper.getInstance());
			}
			
			
			private int? recv_batchDeleteCamera(){
				
				batchDeleteCamera_result result = new batchDeleteCamera_result();
				ReceiveBase(result, batchDeleteCamera_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public int? createCamera(com.vip.xstore.user.face.service.XstoreCameraInfoModel xstoreCameraInfoModel_) {
				
				send_createCamera(xstoreCameraInfoModel_);
				return recv_createCamera(); 
				
			}
			
			
			private void send_createCamera(com.vip.xstore.user.face.service.XstoreCameraInfoModel xstoreCameraInfoModel_){
				
				InitInvocation("createCamera");
				
				createCamera_args args = new createCamera_args();
				args.SetXstoreCameraInfoModel(xstoreCameraInfoModel_);
				
				SendBase(args, createCamera_argsHelper.getInstance());
			}
			
			
			private int? recv_createCamera(){
				
				createCamera_result result = new createCamera_result();
				ReceiveBase(result, createCamera_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public int? deleteCamera(com.vip.xstore.user.face.service.XstoreCameraDelParam delParam_) {
				
				send_deleteCamera(delParam_);
				return recv_deleteCamera(); 
				
			}
			
			
			private void send_deleteCamera(com.vip.xstore.user.face.service.XstoreCameraDelParam delParam_){
				
				InitInvocation("deleteCamera");
				
				deleteCamera_args args = new deleteCamera_args();
				args.SetDelParam(delParam_);
				
				SendBase(args, deleteCamera_argsHelper.getInstance());
			}
			
			
			private int? recv_deleteCamera(){
				
				deleteCamera_result result = new deleteCamera_result();
				ReceiveBase(result, deleteCamera_resultHelper.getInstance());
				
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
			
			
			public com.vip.xstore.user.face.service.XstoreCameraInfoListResult queryCameraList(com.vip.xstore.user.face.service.XstoreCameraPageReqParam pageReqParam_) {
				
				send_queryCameraList(pageReqParam_);
				return recv_queryCameraList(); 
				
			}
			
			
			private void send_queryCameraList(com.vip.xstore.user.face.service.XstoreCameraPageReqParam pageReqParam_){
				
				InitInvocation("queryCameraList");
				
				queryCameraList_args args = new queryCameraList_args();
				args.SetPageReqParam(pageReqParam_);
				
				SendBase(args, queryCameraList_argsHelper.getInstance());
			}
			
			
			private com.vip.xstore.user.face.service.XstoreCameraInfoListResult recv_queryCameraList(){
				
				queryCameraList_result result = new queryCameraList_result();
				ReceiveBase(result, queryCameraList_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.xstore.user.face.service.XstoreCameraStateLogListResult selectCameraStateLog(com.vip.xstore.user.face.service.XstoreCameraStateLogReqParam pageReqParam_) {
				
				send_selectCameraStateLog(pageReqParam_);
				return recv_selectCameraStateLog(); 
				
			}
			
			
			private void send_selectCameraStateLog(com.vip.xstore.user.face.service.XstoreCameraStateLogReqParam pageReqParam_){
				
				InitInvocation("selectCameraStateLog");
				
				selectCameraStateLog_args args = new selectCameraStateLog_args();
				args.SetPageReqParam(pageReqParam_);
				
				SendBase(args, selectCameraStateLog_argsHelper.getInstance());
			}
			
			
			private com.vip.xstore.user.face.service.XstoreCameraStateLogListResult recv_selectCameraStateLog(){
				
				selectCameraStateLog_result result = new selectCameraStateLog_result();
				ReceiveBase(result, selectCameraStateLog_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public int? updateCamera(com.vip.xstore.user.face.service.XstoreCameraUpdateParam updateParam_) {
				
				send_updateCamera(updateParam_);
				return recv_updateCamera(); 
				
			}
			
			
			private void send_updateCamera(com.vip.xstore.user.face.service.XstoreCameraUpdateParam updateParam_){
				
				InitInvocation("updateCamera");
				
				updateCamera_args args = new updateCamera_args();
				args.SetUpdateParam(updateParam_);
				
				SendBase(args, updateCamera_argsHelper.getInstance());
			}
			
			
			private int? recv_updateCamera(){
				
				updateCamera_result result = new updateCamera_result();
				ReceiveBase(result, updateCamera_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.xstore.user.face.service.XstoreCameraStateLogUploadResult uploadCameraStateLog(com.vip.xstore.user.face.service.XstoreCameraStateLogParam xstoreCameraStateLogParam_) {
				
				send_uploadCameraStateLog(xstoreCameraStateLogParam_);
				return recv_uploadCameraStateLog(); 
				
			}
			
			
			private void send_uploadCameraStateLog(com.vip.xstore.user.face.service.XstoreCameraStateLogParam xstoreCameraStateLogParam_){
				
				InitInvocation("uploadCameraStateLog");
				
				uploadCameraStateLog_args args = new uploadCameraStateLog_args();
				args.SetXstoreCameraStateLogParam(xstoreCameraStateLogParam_);
				
				SendBase(args, uploadCameraStateLog_argsHelper.getInstance());
			}
			
			
			private com.vip.xstore.user.face.service.XstoreCameraStateLogUploadResult recv_uploadCameraStateLog(){
				
				uploadCameraStateLog_result result = new uploadCameraStateLog_result();
				ReceiveBase(result, uploadCameraStateLog_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
		}
		
		
	}
	
}