using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.omni.logistics{
	
	
	
	public class ZtoRouteInfoHelper : TBeanSerializer<ZtoRouteInfo>
	{
		
		public static ZtoRouteInfoHelper OBJ = new ZtoRouteInfoHelper();
		
		public static ZtoRouteInfoHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ZtoRouteInfo structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("billCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBillCode(value);
					}
					
					
					
					
					
					if ("scanType".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetScanType(value);
					}
					
					
					
					
					
					if ("scanSite".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetScanSite(value);
					}
					
					
					
					
					
					if ("scanCity".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetScanCity(value);
					}
					
					
					
					
					
					if ("scanDate".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetScanDate(value);
					}
					
					
					
					
					
					if ("desc".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDesc(value);
					}
					
					
					
					
					
					if ("contacts".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetContacts(value);
					}
					
					
					
					
					
					if ("contactsTel".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetContactsTel(value);
					}
					
					
					
					
					
					if ("remark".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRemark(value);
					}
					
					
					
					
					
					if ("remark1".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRemark1(value);
					}
					
					
					
					
					
					if ("remark2".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRemark2(value);
					}
					
					
					
					
					
					if ("remark3".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRemark3(value);
					}
					
					
					
					
					
					if ("remark4".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRemark4(value);
					}
					
					
					
					
					
					if ("remark5".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRemark5(value);
					}
					
					
					
					
					
					if ("remark6".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRemark6(value);
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
		
		
		public void Write(ZtoRouteInfo structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetBillCode() != null) {
				
				oprot.WriteFieldBegin("billCode");
				oprot.WriteString(structs.GetBillCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetScanType() != null) {
				
				oprot.WriteFieldBegin("scanType");
				oprot.WriteString(structs.GetScanType());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetScanSite() != null) {
				
				oprot.WriteFieldBegin("scanSite");
				oprot.WriteString(structs.GetScanSite());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetScanCity() != null) {
				
				oprot.WriteFieldBegin("scanCity");
				oprot.WriteString(structs.GetScanCity());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetScanDate() != null) {
				
				oprot.WriteFieldBegin("scanDate");
				oprot.WriteString(structs.GetScanDate());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDesc() != null) {
				
				oprot.WriteFieldBegin("desc");
				oprot.WriteString(structs.GetDesc());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetContacts() != null) {
				
				oprot.WriteFieldBegin("contacts");
				oprot.WriteString(structs.GetContacts());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetContactsTel() != null) {
				
				oprot.WriteFieldBegin("contactsTel");
				oprot.WriteString(structs.GetContactsTel());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRemark() != null) {
				
				oprot.WriteFieldBegin("remark");
				oprot.WriteString(structs.GetRemark());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRemark1() != null) {
				
				oprot.WriteFieldBegin("remark1");
				oprot.WriteString(structs.GetRemark1());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRemark2() != null) {
				
				oprot.WriteFieldBegin("remark2");
				oprot.WriteString(structs.GetRemark2());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRemark3() != null) {
				
				oprot.WriteFieldBegin("remark3");
				oprot.WriteString(structs.GetRemark3());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRemark4() != null) {
				
				oprot.WriteFieldBegin("remark4");
				oprot.WriteString(structs.GetRemark4());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRemark5() != null) {
				
				oprot.WriteFieldBegin("remark5");
				oprot.WriteString(structs.GetRemark5());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRemark6() != null) {
				
				oprot.WriteFieldBegin("remark6");
				oprot.WriteString(structs.GetRemark6());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ZtoRouteInfo bean){
			
			
		}
		
	}
	
}