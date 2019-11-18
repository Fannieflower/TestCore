using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.xstore.order.common.pojo.vo{
	
	
	
	public class InfErpMRetailItemVOHelper : TBeanSerializer<InfErpMRetailItemVO>
	{
		
		public static InfErpMRetailItemVOHelper OBJ = new InfErpMRetailItemVOHelper();
		
		public static InfErpMRetailItemVOHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(InfErpMRetailItemVO structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("mRetailId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetMRetailId(value);
					}
					
					
					
					
					
					if ("mProductalias".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetMProductalias(value);
					}
					
					
					
					
					
					if ("pricelist".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPricelist(value);
					}
					
					
					
					
					
					if ("priceactual".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPriceactual(value);
					}
					
					
					
					
					
					if ("discount".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDiscount(value);
					}
					
					
					
					
					
					if ("qty".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetQty(value);
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
					
					
					
					
					
					if ("orgdocno".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrgdocno(value);
					}
					
					
					
					
					
					if ("webposRetreasonId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetWebposRetreasonId(value);
					}
					
					
					
					
					
					if ("webposRetreason".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetWebposRetreason(value);
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
					
					
					
					
					
					if ("salesrepNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSalesrepNo(value);
					}
					
					
					
					
					
					if ("realQty".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetRealQty(value);
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
		
		
		public void Write(InfErpMRetailItemVO structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetId() != null) {
				
				oprot.WriteFieldBegin("id");
				oprot.WriteI64((long)structs.GetId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMRetailId() != null) {
				
				oprot.WriteFieldBegin("mRetailId");
				oprot.WriteI64((long)structs.GetMRetailId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMProductalias() != null) {
				
				oprot.WriteFieldBegin("mProductalias");
				oprot.WriteString(structs.GetMProductalias());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPricelist() != null) {
				
				oprot.WriteFieldBegin("pricelist");
				oprot.WriteString(structs.GetPricelist());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPriceactual() != null) {
				
				oprot.WriteFieldBegin("priceactual");
				oprot.WriteString(structs.GetPriceactual());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDiscount() != null) {
				
				oprot.WriteFieldBegin("discount");
				oprot.WriteString(structs.GetDiscount());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetQty() != null) {
				
				oprot.WriteFieldBegin("qty");
				oprot.WriteI32((int)structs.GetQty()); 
				
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
			
			
			if(structs.GetOrgdocno() != null) {
				
				oprot.WriteFieldBegin("orgdocno");
				oprot.WriteString(structs.GetOrgdocno());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetWebposRetreasonId() != null) {
				
				oprot.WriteFieldBegin("webposRetreasonId");
				oprot.WriteI64((long)structs.GetWebposRetreasonId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetWebposRetreason() != null) {
				
				oprot.WriteFieldBegin("webposRetreason");
				oprot.WriteString(structs.GetWebposRetreason());
				
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
			
			
			if(structs.GetSalesrepNo() != null) {
				
				oprot.WriteFieldBegin("salesrepNo");
				oprot.WriteString(structs.GetSalesrepNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRealQty() != null) {
				
				oprot.WriteFieldBegin("realQty");
				oprot.WriteI32((int)structs.GetRealQty()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(InfErpMRetailItemVO bean){
			
			
		}
		
	}
	
}