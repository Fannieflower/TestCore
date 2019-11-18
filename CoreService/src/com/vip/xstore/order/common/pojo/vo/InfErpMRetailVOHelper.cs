using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.xstore.order.common.pojo.vo{
	
	
	
	public class InfErpMRetailVOHelper : TBeanSerializer<InfErpMRetailVO>
	{
		
		public static InfErpMRetailVOHelper OBJ = new InfErpMRetailVOHelper();
		
		public static InfErpMRetailVOHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(InfErpMRetailVO structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("id".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetId(value);
					}
					
					
					
					
					
					if ("docno".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDocno(value);
					}
					
					
					
					
					
					if ("splitDocno".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSplitDocno(value);
					}
					
					
					
					
					
					if ("billdate".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetBilldate(value);
					}
					
					
					
					
					
					if ("refno".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRefno(value);
					}
					
					
					
					
					
					if ("openid".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOpenid(value);
					}
					
					
					
					
					
					if ("rfidDocno".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRfidDocno(value);
					}
					
					
					
					
					
					if ("retailbilltype".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRetailbilltype(value);
					}
					
					
					
					
					
					if ("cStoreId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetCStoreId(value);
					}
					
					
					
					
					
					if ("cStore".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCStore(value);
					}
					
					
					
					
					
					if ("uploadtype".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUploadtype(value);
					}
					
					
					
					
					
					if ("salesrepId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetSalesrepId(value);
					}
					
					
					
					
					
					if ("salesrep".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSalesrep(value);
					}
					
					
					
					
					
					if ("planNum".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPlanNum(value);
					}
					
					
					
					
					
					if ("description".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDescription(value);
					}
					
					
					
					
					
					if ("totLines".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetTotLines(value);
					}
					
					
					
					
					
					if ("totQty".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetTotQty(value);
					}
					
					
					
					
					
					if ("totAmtList".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTotAmtList(value);
					}
					
					
					
					
					
					if ("totAmtActual".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTotAmtActual(value);
					}
					
					
					
					
					
					if ("avgDiscount".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAvgDiscount(value);
					}
					
					
					
					
					
					if ("o2oSo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetO2oSo(value);
					}
					
					
					
					
					
					if ("ownerid".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetOwnerid(value);
					}
					
					
					
					
					
					if ("owner".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOwner(value);
					}
					
					
					
					
					
					if ("creationdate".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetCreationdate(value);
					}
					
					
					
					
					
					if ("modifierid".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetModifierid(value);
					}
					
					
					
					
					
					if ("modifier".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetModifier(value);
					}
					
					
					
					
					
					if ("modifieddate".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetModifieddate(value);
					}
					
					
					
					
					
					if ("statuserid".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetStatuserid(value);
					}
					
					
					
					
					
					if ("statuser".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetStatuser(value);
					}
					
					
					
					
					
					if ("statustime".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetStatustime(value);
					}
					
					
					
					
					
					if ("orgdocno".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrgdocno(value);
					}
					
					
					
					
					
					if ("companyCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCompanyCode(value);
					}
					
					
					
					
					
					if ("procTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetProcTime(value);
					}
					
					
					
					
					
					if ("procStatus".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetProcStatus(value);
					}
					
					
					
					
					
					if ("errorCount".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetErrorCount(value);
					}
					
					
					
					
					
					if ("errorMsg".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetErrorMsg(value);
					}
					
					
					
					
					
					if ("createTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetCreateTime(value);
					}
					
					
					
					
					
					if ("updateTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetUpdateTime(value);
					}
					
					
					
					
					
					if ("isDeleted".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIsDeleted(value);
					}
					
					
					
					
					
					if ("relatedDocno".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRelatedDocno(value);
					}
					
					
					
					
					
					if ("storeAfterSaleSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetStoreAfterSaleSn(value);
					}
					
					
					
					
					
					if ("salesrepNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSalesrepNo(value);
					}
					
					
					
					
					if(needSkip){
						
						ProtocolUtil.skip(iprot);
					}
					
					iprot.ReadFieldEnd();
				}
				
				iprot.ReadStructEnd();
				Validate(structs);
			}
			else{
				
				throw new OspException();
			}
			
			
		}
		
		
		public void Write(InfErpMRetailVO structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetId() != null) {
				
				oprot.WriteFieldBegin("id");
				oprot.WriteI64((long)structs.GetId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDocno() != null) {
				
				oprot.WriteFieldBegin("docno");
				oprot.WriteString(structs.GetDocno());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSplitDocno() != null) {
				
				oprot.WriteFieldBegin("splitDocno");
				oprot.WriteString(structs.GetSplitDocno());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBilldate() != null) {
				
				oprot.WriteFieldBegin("billdate");
				oprot.WriteI32((int)structs.GetBilldate()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRefno() != null) {
				
				oprot.WriteFieldBegin("refno");
				oprot.WriteString(structs.GetRefno());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOpenid() != null) {
				
				oprot.WriteFieldBegin("openid");
				oprot.WriteString(structs.GetOpenid());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRfidDocno() != null) {
				
				oprot.WriteFieldBegin("rfidDocno");
				oprot.WriteString(structs.GetRfidDocno());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRetailbilltype() != null) {
				
				oprot.WriteFieldBegin("retailbilltype");
				oprot.WriteString(structs.GetRetailbilltype());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCStoreId() != null) {
				
				oprot.WriteFieldBegin("cStoreId");
				oprot.WriteI64((long)structs.GetCStoreId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCStore() != null) {
				
				oprot.WriteFieldBegin("cStore");
				oprot.WriteString(structs.GetCStore());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUploadtype() != null) {
				
				oprot.WriteFieldBegin("uploadtype");
				oprot.WriteString(structs.GetUploadtype());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSalesrepId() != null) {
				
				oprot.WriteFieldBegin("salesrepId");
				oprot.WriteI64((long)structs.GetSalesrepId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSalesrep() != null) {
				
				oprot.WriteFieldBegin("salesrep");
				oprot.WriteString(structs.GetSalesrep());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPlanNum() != null) {
				
				oprot.WriteFieldBegin("planNum");
				oprot.WriteString(structs.GetPlanNum());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDescription() != null) {
				
				oprot.WriteFieldBegin("description");
				oprot.WriteString(structs.GetDescription());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTotLines() != null) {
				
				oprot.WriteFieldBegin("totLines");
				oprot.WriteI32((int)structs.GetTotLines()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTotQty() != null) {
				
				oprot.WriteFieldBegin("totQty");
				oprot.WriteI32((int)structs.GetTotQty()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTotAmtList() != null) {
				
				oprot.WriteFieldBegin("totAmtList");
				oprot.WriteString(structs.GetTotAmtList());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTotAmtActual() != null) {
				
				oprot.WriteFieldBegin("totAmtActual");
				oprot.WriteString(structs.GetTotAmtActual());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAvgDiscount() != null) {
				
				oprot.WriteFieldBegin("avgDiscount");
				oprot.WriteString(structs.GetAvgDiscount());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetO2oSo() != null) {
				
				oprot.WriteFieldBegin("o2oSo");
				oprot.WriteString(structs.GetO2oSo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOwnerid() != null) {
				
				oprot.WriteFieldBegin("ownerid");
				oprot.WriteI64((long)structs.GetOwnerid()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOwner() != null) {
				
				oprot.WriteFieldBegin("owner");
				oprot.WriteString(structs.GetOwner());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCreationdate() != null) {
				
				oprot.WriteFieldBegin("creationdate");
				oprot.WriteI32((int)structs.GetCreationdate()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetModifierid() != null) {
				
				oprot.WriteFieldBegin("modifierid");
				oprot.WriteI64((long)structs.GetModifierid()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetModifier() != null) {
				
				oprot.WriteFieldBegin("modifier");
				oprot.WriteString(structs.GetModifier());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetModifieddate() != null) {
				
				oprot.WriteFieldBegin("modifieddate");
				oprot.WriteI32((int)structs.GetModifieddate()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStatuserid() != null) {
				
				oprot.WriteFieldBegin("statuserid");
				oprot.WriteI64((long)structs.GetStatuserid()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStatuser() != null) {
				
				oprot.WriteFieldBegin("statuser");
				oprot.WriteString(structs.GetStatuser());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStatustime() != null) {
				
				oprot.WriteFieldBegin("statustime");
				oprot.WriteI32((int)structs.GetStatustime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrgdocno() != null) {
				
				oprot.WriteFieldBegin("orgdocno");
				oprot.WriteString(structs.GetOrgdocno());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCompanyCode() != null) {
				
				oprot.WriteFieldBegin("companyCode");
				oprot.WriteString(structs.GetCompanyCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetProcTime() != null) {
				
				oprot.WriteFieldBegin("procTime");
				oprot.WriteI64((long)structs.GetProcTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetProcStatus() != null) {
				
				oprot.WriteFieldBegin("procStatus");
				oprot.WriteI32((int)structs.GetProcStatus()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetErrorCount() != null) {
				
				oprot.WriteFieldBegin("errorCount");
				oprot.WriteI32((int)structs.GetErrorCount()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetErrorMsg() != null) {
				
				oprot.WriteFieldBegin("errorMsg");
				oprot.WriteString(structs.GetErrorMsg());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCreateTime() != null) {
				
				oprot.WriteFieldBegin("createTime");
				oprot.WriteI64((long)structs.GetCreateTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUpdateTime() != null) {
				
				oprot.WriteFieldBegin("updateTime");
				oprot.WriteI64((long)structs.GetUpdateTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsDeleted() != null) {
				
				oprot.WriteFieldBegin("isDeleted");
				oprot.WriteI32((int)structs.GetIsDeleted()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRelatedDocno() != null) {
				
				oprot.WriteFieldBegin("relatedDocno");
				oprot.WriteString(structs.GetRelatedDocno());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStoreAfterSaleSn() != null) {
				
				oprot.WriteFieldBegin("storeAfterSaleSn");
				oprot.WriteString(structs.GetStoreAfterSaleSn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSalesrepNo() != null) {
				
				oprot.WriteFieldBegin("salesrepNo");
				oprot.WriteString(structs.GetSalesrepNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(InfErpMRetailVO bean){
			
			
		}
		
	}
	
}