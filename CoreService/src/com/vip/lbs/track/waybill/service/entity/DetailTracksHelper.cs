using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.lbs.track.waybill.service.entity{
	
	
	
	public class DetailTracksHelper : TBeanSerializer<DetailTracks>
	{
		
		public static DetailTracksHelper OBJ = new DetailTracksHelper();
		
		public static DetailTracksHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(DetailTracks structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("state".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetState(value);
					}
					
					
					
					
					
					if ("trackDesc".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTrackDesc(value);
					}
					
					
					
					
					
					if ("dispRecMan".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDispRecMan(value);
					}
					
					
					
					
					
					if ("dispRecManPhone".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDispRecManPhone(value);
					}
					
					
					
					
					
					if ("scanType".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetScanType(value);
					}
					
					
					
					
					
					if ("preNextCity".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPreNextCity(value);
					}
					
					
					
					
					
					if ("preNextProv".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPreNextProv(value);
					}
					
					
					
					
					
					if ("preNextSite".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPreNextSite(value);
					}
					
					
					
					
					
					if ("preNextSiteCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPreNextSiteCode(value);
					}
					
					
					
					
					
					if ("preNextSitePhone".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPreNextSitePhone(value);
					}
					
					
					
					
					
					if ("signMan".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSignMan(value);
					}
					
					
					
					
					
					if ("scanSitePhone".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetScanSitePhone(value);
					}
					
					
					
					
					
					if ("remark".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRemark(value);
					}
					
					
					
					
					
					if ("trackCreateTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetTrackCreateTime(value);
					}
					
					
					
					
					
					if ("trackCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTrackCode(value);
					}
					
					
					
					
					
					if ("siteCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSiteCode(value);
					}
					
					
					
					
					
					if ("siteName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSiteName(value);
					}
					
					
					
					
					
					if ("extendFields".Equals(schemeField.Trim())){
						
						needSkip = false;
						Dictionary<string, string> value;
						
						value = new Dictionary<string, string>();
						iprot.ReadMapBegin();
						while(true){
							
							try{
								
								string _key0;
								string _val0;
								_key0 = iprot.ReadString();
								
								_val0 = iprot.ReadString();
								
								value.Add(_key0, _val0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadMapEnd();
						
						structs.SetExtendFields(value);
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
		
		
		public void Write(DetailTracks structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetState() != null) {
				
				oprot.WriteFieldBegin("state");
				oprot.WriteI32((int)structs.GetState()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("state can not be null!");
			}
			
			
			if(structs.GetTrackDesc() != null) {
				
				oprot.WriteFieldBegin("trackDesc");
				oprot.WriteString(structs.GetTrackDesc());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("trackDesc can not be null!");
			}
			
			
			if(structs.GetDispRecMan() != null) {
				
				oprot.WriteFieldBegin("dispRecMan");
				oprot.WriteString(structs.GetDispRecMan());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDispRecManPhone() != null) {
				
				oprot.WriteFieldBegin("dispRecManPhone");
				oprot.WriteString(structs.GetDispRecManPhone());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetScanType() != null) {
				
				oprot.WriteFieldBegin("scanType");
				oprot.WriteString(structs.GetScanType());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPreNextCity() != null) {
				
				oprot.WriteFieldBegin("preNextCity");
				oprot.WriteString(structs.GetPreNextCity());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPreNextProv() != null) {
				
				oprot.WriteFieldBegin("preNextProv");
				oprot.WriteString(structs.GetPreNextProv());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPreNextSite() != null) {
				
				oprot.WriteFieldBegin("preNextSite");
				oprot.WriteString(structs.GetPreNextSite());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPreNextSiteCode() != null) {
				
				oprot.WriteFieldBegin("preNextSiteCode");
				oprot.WriteString(structs.GetPreNextSiteCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPreNextSitePhone() != null) {
				
				oprot.WriteFieldBegin("preNextSitePhone");
				oprot.WriteString(structs.GetPreNextSitePhone());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSignMan() != null) {
				
				oprot.WriteFieldBegin("signMan");
				oprot.WriteString(structs.GetSignMan());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetScanSitePhone() != null) {
				
				oprot.WriteFieldBegin("scanSitePhone");
				oprot.WriteString(structs.GetScanSitePhone());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRemark() != null) {
				
				oprot.WriteFieldBegin("remark");
				oprot.WriteString(structs.GetRemark());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("remark can not be null!");
			}
			
			
			if(structs.GetTrackCreateTime() != null) {
				
				oprot.WriteFieldBegin("trackCreateTime");
				oprot.WriteI64((long)structs.GetTrackCreateTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("trackCreateTime can not be null!");
			}
			
			
			if(structs.GetTrackCode() != null) {
				
				oprot.WriteFieldBegin("trackCode");
				oprot.WriteString(structs.GetTrackCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSiteCode() != null) {
				
				oprot.WriteFieldBegin("siteCode");
				oprot.WriteString(structs.GetSiteCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSiteName() != null) {
				
				oprot.WriteFieldBegin("siteName");
				oprot.WriteString(structs.GetSiteName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetExtendFields() != null) {
				
				oprot.WriteFieldBegin("extendFields");
				
				oprot.WriteMapBegin();
				foreach(KeyValuePair< string, string > _ir0 in structs.GetExtendFields()){
					
					string _key0 = _ir0.Key;
					string _value0 = _ir0.Value;
					oprot.WriteString(_key0);
					
					oprot.WriteString(_value0);
					
				}
				
				oprot.WriteMapEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(DetailTracks bean){
			
			
		}
		
	}
	
}