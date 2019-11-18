using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace com.vip.vop.vcloud.product{
	
	
	public class FendiProductSynServiceHelper {
		
		
		
		public class handleImages_args {
			
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class parseAndSave_args {
			
			
		}
		
		
		
		
		public class parseAndSaveCategory_args {
			
			
		}
		
		
		
		
		public class pushCategoryToVdg_args {
			
			
		}
		
		
		
		
		public class handleImages_result {
			
			
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
		
		
		
		
		public class parseAndSave_result {
			
			
		}
		
		
		
		
		public class parseAndSaveCategory_result {
			
			
		}
		
		
		
		
		public class pushCategoryToVdg_result {
			
			
		}
		
		
		
		
		
		public class handleImages_argsHelper : TBeanSerializer<handleImages_args>
		{
			
			public static handleImages_argsHelper OBJ = new handleImages_argsHelper();
			
			public static handleImages_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(handleImages_args structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(handleImages_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(handleImages_args bean){
				
				
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
		
		
		
		
		public class parseAndSave_argsHelper : TBeanSerializer<parseAndSave_args>
		{
			
			public static parseAndSave_argsHelper OBJ = new parseAndSave_argsHelper();
			
			public static parseAndSave_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(parseAndSave_args structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(parseAndSave_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(parseAndSave_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class parseAndSaveCategory_argsHelper : TBeanSerializer<parseAndSaveCategory_args>
		{
			
			public static parseAndSaveCategory_argsHelper OBJ = new parseAndSaveCategory_argsHelper();
			
			public static parseAndSaveCategory_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(parseAndSaveCategory_args structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(parseAndSaveCategory_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(parseAndSaveCategory_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class pushCategoryToVdg_argsHelper : TBeanSerializer<pushCategoryToVdg_args>
		{
			
			public static pushCategoryToVdg_argsHelper OBJ = new pushCategoryToVdg_argsHelper();
			
			public static pushCategoryToVdg_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(pushCategoryToVdg_args structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(pushCategoryToVdg_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(pushCategoryToVdg_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class handleImages_resultHelper : TBeanSerializer<handleImages_result>
		{
			
			public static handleImages_resultHelper OBJ = new handleImages_resultHelper();
			
			public static handleImages_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(handleImages_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(handleImages_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(handleImages_result bean){
				
				
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
		
		
		
		
		public class parseAndSave_resultHelper : TBeanSerializer<parseAndSave_result>
		{
			
			public static parseAndSave_resultHelper OBJ = new parseAndSave_resultHelper();
			
			public static parseAndSave_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(parseAndSave_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(parseAndSave_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(parseAndSave_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class parseAndSaveCategory_resultHelper : TBeanSerializer<parseAndSaveCategory_result>
		{
			
			public static parseAndSaveCategory_resultHelper OBJ = new parseAndSaveCategory_resultHelper();
			
			public static parseAndSaveCategory_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(parseAndSaveCategory_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(parseAndSaveCategory_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(parseAndSaveCategory_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class pushCategoryToVdg_resultHelper : TBeanSerializer<pushCategoryToVdg_result>
		{
			
			public static pushCategoryToVdg_resultHelper OBJ = new pushCategoryToVdg_resultHelper();
			
			public static pushCategoryToVdg_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(pushCategoryToVdg_result structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(pushCategoryToVdg_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(pushCategoryToVdg_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class FendiProductSynServiceClient : OspRestStub , FendiProductSynService  {
			
			
			public FendiProductSynServiceClient():base("com.vip.vop.vcloud.product.FendiProductSynService","1.0.0") {
				
				
			}
			
			
			
			public void handleImages() {
				
				send_handleImages();
				recv_handleImages();
				
			}
			
			
			private void send_handleImages(){
				
				InitInvocation("handleImages");
				
				handleImages_args args = new handleImages_args();
				
				SendBase(args, handleImages_argsHelper.getInstance());
			}
			
			
			private void recv_handleImages(){
				
				handleImages_result result = new handleImages_result();
				ReceiveBase(result, handleImages_resultHelper.getInstance());
				
				
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
			
			
			public void parseAndSave() {
				
				send_parseAndSave();
				recv_parseAndSave();
				
			}
			
			
			private void send_parseAndSave(){
				
				InitInvocation("parseAndSave");
				
				parseAndSave_args args = new parseAndSave_args();
				
				SendBase(args, parseAndSave_argsHelper.getInstance());
			}
			
			
			private void recv_parseAndSave(){
				
				parseAndSave_result result = new parseAndSave_result();
				ReceiveBase(result, parseAndSave_resultHelper.getInstance());
				
				
			}
			
			
			public void parseAndSaveCategory() {
				
				send_parseAndSaveCategory();
				recv_parseAndSaveCategory();
				
			}
			
			
			private void send_parseAndSaveCategory(){
				
				InitInvocation("parseAndSaveCategory");
				
				parseAndSaveCategory_args args = new parseAndSaveCategory_args();
				
				SendBase(args, parseAndSaveCategory_argsHelper.getInstance());
			}
			
			
			private void recv_parseAndSaveCategory(){
				
				parseAndSaveCategory_result result = new parseAndSaveCategory_result();
				ReceiveBase(result, parseAndSaveCategory_resultHelper.getInstance());
				
				
			}
			
			
			public void pushCategoryToVdg() {
				
				send_pushCategoryToVdg();
				recv_pushCategoryToVdg();
				
			}
			
			
			private void send_pushCategoryToVdg(){
				
				InitInvocation("pushCategoryToVdg");
				
				pushCategoryToVdg_args args = new pushCategoryToVdg_args();
				
				SendBase(args, pushCategoryToVdg_argsHelper.getInstance());
			}
			
			
			private void recv_pushCategoryToVdg(){
				
				pushCategoryToVdg_result result = new pushCategoryToVdg_result();
				ReceiveBase(result, pushCategoryToVdg_resultHelper.getInstance());
				
				
			}
			
			
		}
		
		
	}
	
}